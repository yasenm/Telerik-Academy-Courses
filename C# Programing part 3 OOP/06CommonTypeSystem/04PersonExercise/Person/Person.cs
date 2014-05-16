using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Person
{
    public string Name { get; private set; }
    public int? Age 
    { 
        get; private set; }

    public Person(string name) 
    {
        this.Name = name;
    }

    public Person(string name, int? age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder("--------PERSON--------\n");
        if (this.Name == null)
        {
            result.Append("Name : no name specified!\n");
        }
        else
        {
            result.Append(String.Format("Name : {0};\n", this.Name));
        }
        if (this.Age == null)
        {
            result.Append("Age : not specified!\n");
        }
        else if (this.Age < 0 || this.Age > 120)
        {
            throw new ArgumentOutOfRangeException("Invalid age input. Should be between [0...120]");
        }
        else
        {
            result.Append(String.Format("Age : {0,3};\n", this.Age));
        }
        return result.ToString();
    }

}
