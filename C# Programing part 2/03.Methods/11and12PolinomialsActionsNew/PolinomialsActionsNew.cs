using System;
using System.Collections;


namespace _11and12PolinomialsActionsNew
{
    class PolinomialsActionsNew
    {
        //method that return the max out of two ints
        static int GetMax(int lower, int higher)
        {
            if (lower < higher)
            {
                lower = higher;
            }
            return lower;
        }

        //printing polinom array
        static void PrintPolinomArray(int[] array)
        {
            Console.Write("Polinom is : ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                string sign = "";
                if (i < array.Length - 1 )
                {
                    sign = "+";
                    if (array[i] < 0)
                    {
                        sign = "-";
                    }
                }
                Console.Write("{2} {0}*x^{1} ", array[i], i, sign);
            }
            Console.WriteLine();
        }

        //printing regular array
        static void PrintArray(IEnumerable array) 
        {
            foreach (var item in array)
            {
                Console.Write("|{0,3}|",item);
            }
            Console.WriteLine();
        }

        //input the values of the polinom in array
        static void InputValuesArray(int[] array) 
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("x^{0} * ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        //add polinoms
        static int[] AddPolinoms(int[] firstPoliArray, int[] secondPoliArray)
        {
            int[] result;
            if (firstPoliArray.Length >= secondPoliArray.Length)
            {
                result = new int[firstPoliArray.Length];
                for (int i = 0; i < firstPoliArray.Length; i++)
                {
                    int secondIndex = i;
                    int secondInt = 0;
                    if (secondIndex < secondPoliArray.Length)
                    {
                        secondInt = secondPoliArray[secondIndex];
                    }
                    result[i] = firstPoliArray[i] + secondInt;
                }
            }
            else
            {
                result = AddPolinoms(secondPoliArray, firstPoliArray);
            }

            return result;
        }

        //substract polinoms
        static int[] SubstractPolinoms(int[] firstPoliArray, int[] secondPoliArray)
        {
            int[] result;
            if (firstPoliArray.Length >= secondPoliArray.Length)
            {
                result = new int[firstPoliArray.Length];
                for (int i = 0; i < firstPoliArray.Length; i++)
                {
                    int secondIndex = i;
                    int secondInt = 0;
                    if (secondIndex < secondPoliArray.Length)
                    {
                        secondInt = secondPoliArray[secondIndex];
                    }
                    result[i] = firstPoliArray[i] - secondInt;
                }
            }
            else
            {
                result = AddPolinoms(secondPoliArray, firstPoliArray);
            }

            return result;
        }

        //main method
        static void Main()
        {
            Console.WriteLine("Format of polinomials : a(0)*x^n + a(1)*x^(n-1) + ..... + a(n)*x + a(n) = p(x);");

            Console.WriteLine("Enter the maximal exponent for first polinom");
            Console.Write("First exponent n1 = ");
            int exponentN1 = int.Parse(Console.ReadLine());
            int[] firstPolinomialArray = new int[exponentN1 + 1];
            InputValuesArray(firstPolinomialArray);
            PrintPolinomArray(firstPolinomialArray);

            Console.WriteLine("Enter the maximal exponent for second polinom");
            Console.Write("Second exponent n2 = ");
            int exponentN2 = int.Parse(Console.ReadLine());
            int[] secondPolinomialArray = new int[exponentN2 + 1];
            InputValuesArray(secondPolinomialArray);
            PrintPolinomArray(secondPolinomialArray);

            int len = GetMax(secondPolinomialArray.Length, firstPolinomialArray.Length);

            //add the two polinoms
            int[] resultAdd = new int[len];
            resultAdd = AddPolinoms(firstPolinomialArray, secondPolinomialArray);
            Console.WriteLine("Result array by adding two polinoms is : ");
            PrintArray(resultAdd);

            //print result by adding
            Console.WriteLine("Polinom result by adding two is : ");
            PrintPolinomArray(resultAdd);
            Console.WriteLine();

            //substract the two polinoms
            int[] resultSubstract = new int[len];
            resultSubstract = SubstractPolinoms(firstPolinomialArray, secondPolinomialArray);
            Console.WriteLine("Result array by substracting two polinoms is : ");
            PrintArray(resultSubstract);

            //print result by substracting
            Console.WriteLine("Polinom result by adding two is : ");
            PrintPolinomArray(resultSubstract);
            Console.WriteLine();
        }
    }
}
