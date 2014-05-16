﻿using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace HTMLRenderer
{
	public interface IElement
	{
		string Name { get; }
		string TextContent { get; set; }
		IEnumerable<IElement> ChildElements { get; }
		void AddElement(IElement element);
		void Render(StringBuilder output);
		string ToString();
	}

	public interface ITable : IElement
	{
		int Rows { get; }
		int Cols { get; }
		IElement this[int row, int col] { get; set; }
	}

    public interface IElementFactory
    {
		IElement CreateElement(string name);
		IElement CreateElement(string name, string content);
		ITable CreateTable(int rows, int cols);
    }

    public class HTMLElementFactory : IElementFactory
    {
		public IElement CreateElement(string name)
        {
            HTMLElement result = new HTMLElement();
            result.Name = name;
            return result;
		}

		public IElement CreateElement(string name, string content)
		{
            HTMLElement result = new HTMLElement();
            result.Name = name;
            result.TextContent = content;
            return result;
		}

		public ITable CreateTable(int rows, int cols)
		{
            return new HTMLTable(rows, cols);
		}
	}

    public class HTMLElement : IElement
    {

        public string Name { get; set; }

        public string TextContent { get; set; }

        public IList<IElement> childElements = new List<IElement>();

        public IEnumerable<IElement> ChildElements
        {
            get { return childElements; }
        }

        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public void Render(StringBuilder output)
        {
            if (this.Name != null)
            {
                output.Append(string.Format("<{0}>", this.Name));
            }

            if (this.TextContent != null)
            {
                output.Append(this.TextContent);
            }

            if (this.childElements.Count > 0)
            {
                foreach (var element in this.childElements)
                {
                    element.Render(output);
                }
            }

            if (this.Name != null)
            {
                output.Append(string.Format("</{0}>", this.Name));
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            this.Render(result);
            return result.ToString();
        }
    }

    public class HTMLTable : HTMLElement, ITable
    {
        public int Rows { get; set; }

        public int Cols { get; set; }

        public HTMLTable(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.tableElements = new IElement[this.Rows, this.Cols];
        }

        public IElement[,] tableElements;

        public IElement this[int row, int col]
        {
            get
            {
                return this.tableElements[row, col];
            }
            set
            {
                this.tableElements[row, col] = value;
            }
        }

        public void Render(StringBuilder output)
        {
            output.Append("<table>");

            for (int row = 0; row < this.Rows; row++)
            {
                output.Append("<tr>");

                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append("<td>");
                    output.Append(tableElements[row, col]);
                    output.Append("</td>");

                }

                output.Append("</tr>");
            }

            output.Append("</table>");
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            this.Render(result);
            return result.ToString();
        }
    }

    public class HTMLRendererCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using HTMLRenderer;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}
