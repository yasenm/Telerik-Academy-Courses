using System;
using System.Collections;

//Write a method that adds two polynomials. Represent them as arrays
//of their coefficients as in the example below:
//x2 + 5 = 1x2 + 0x + 5  | 5 | 0 | 1 |

namespace _11and12PolinomialsActions
{
    class PolinomialsActions
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

        //we get the exponent after spliting polinom
        static int ExtractMaximalExponent(string[] polinomalArray) 
        {
            int exponent;
            exponent = int.Parse(polinomalArray[1]);
            return exponent;
        }


        //make from array string
        static string MakeFromArrayString(IEnumerable array) 
        {
            string result = "";
            foreach (var item in array)
            {
                result += item;
            }
            return result;
        }

        //add two polinomials
        static string AddTwoPolinomials(int exponent, string[] firstPolinomialArray, string[] secondPolinomialArray) 
        {
            string result = "";
            int[] polinomalMultipliers = new int[exponent];
            for (int i = 0; i < polinomalMultipliers.Length; i++)
            {
                polinomalMultipliers[i] = 0;
            }

            for (int i = polinomalMultipliers.Length - 1; i >= 0; i--)
            {
                
            }
            string firstPoli = MakeFromArrayString(firstPolinomialArray);
            string secondPoli = MakeFromArrayString(secondPolinomialArray);


            return result;
        }

        static void Main()
        {
            Console.WriteLine("Format of polinomials : a(0)*x^n + a(1)*x^(n-1) + ..... + a(n)*x + a(n) = p(x);");
            Console.WriteLine("'n' maximal value 8. Example : x2 + 5 = 1x2 + 0x + 5");

            //input region
            Console.Write("Enter first polinomial : ");
            string firstPolinomial = Console.ReadLine();
            Console.Write("Enter second polinomial : ");
            string secondPolinomial = Console.ReadLine();
            char[] charSeparators = new char[] {'x','*'};

            //separate input data to arrays
            string[] firstPolinomialArray = firstPolinomial.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            string[] secondPolinomialArray = secondPolinomial.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            //find the exponent of each polinom
            int exponentFirstPolinomial = ExtractMaximalExponent(firstPolinomialArray);
            int exponentSecondPolinomial = ExtractMaximalExponent(secondPolinomialArray);

            //find the max exponent
            int maxExponent = GetMax(exponentFirstPolinomial, exponentSecondPolinomial);
            string result = AddTwoPolinomials(maxExponent,firstPolinomialArray,secondPolinomialArray);
            Console.WriteLine();
        }
    }
}
