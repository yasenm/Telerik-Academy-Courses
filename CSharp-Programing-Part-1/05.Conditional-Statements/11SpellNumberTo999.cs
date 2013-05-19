using System;

//Write a program that converts a number in the range [0...999] to a text 
//corresponding to its English pronunciation. Examples:
//    - 0  "Zero"
//    - 273  "Two hundred seventy three"
//    - 400  "Four hundred"
//    - 501  "Five hundred and one"
//    - 711  "Seven hundred and eleven"

class SpellNumberTo999
{
    static void Main()
    {
        Console.WriteLine("Enter number between 0 and 999!");
        Console.Write("Input you choice : ");
        int numReal = int.Parse(Console.ReadLine());
        int numForOnes = numReal % 10;
        int numForTens = (numReal / 10) % 10;
        int numForHundreds =  (numReal/ 100) % 10;

        if (numReal < 20)
        {
            string strForOnes = "";
          switch (numReal) {
                case 0: strForOnes = "Zero"; break;
                case 1: strForOnes = "One"; break;
                case 2: strForOnes = "Two"; break;
                case 3: strForOnes = "Three"; break;
                case 4: strForOnes = "Four"; break;
                case 5: strForOnes = "Five"; break;
                case 6: strForOnes = "Six"; break;
                case 7: strForOnes = "Seven"; break;
                case 8: strForOnes = "Eight"; break;
                case 9: strForOnes = "Nine"; break;
                case 10: strForOnes = "Ten"; break;
                case 11: strForOnes = "Eleven"; break;
                case 12: strForOnes = "Twelve"; break;
                case 13: strForOnes = "Threeteen"; break;
                case 14: strForOnes = "Fourteen"; break;
                case 15: strForOnes = "Fiveteen"; break;
                case 16: strForOnes = "Sixteen"; break;
                case 17: strForOnes = "Seventeen"; break;
                case 18: strForOnes = "Eightteen"; break;
                case 19: strForOnes = "Nineteen"; break;
	        }
            Console.WriteLine(numReal + " --> " + strForOnes);
	    }
	    else if (numReal >= 20 && numReal <100 )
        {
            string strForTens = "";
	        switch (numForTens) {
	            case 2: strForTens = "Twenty"; break;
	            case 3: strForTens = "Thirty"; break;
	            case 4: strForTens = "Fourty"; break;
	            case 5: strForTens = "Fifty"; break;
	            case 6: strForTens = "Sixty"; break;
	            case 7: strForTens = "Seventy"; break;
	            case 8: strForTens = "Eighty"; break;
	            case 9: strForTens = "Ninety"; break;
	        }
            if (numForOnes >= 1)
            {
                string strForOnes = "";
	            switch (numForOnes) {
                    case 1: strForOnes = "one"; break;
                    case 2: strForOnes = "two"; break;
                    case 3: strForOnes = "three"; break;
                    case 4: strForOnes = "four"; break;
                    case 5: strForOnes = "five"; break;
                    case 6: strForOnes = "six"; break;
                    case 7: strForOnes = "seven"; break;
                    case 8: strForOnes = "eight"; break;
                    case 9: strForOnes = "nine"; break;
	            }
                Console.WriteLine(numReal + " --> " + strForTens + strForOnes);
	        }
	        else {
                Console.WriteLine(numReal + " --> " + strForTens);
	        }
	    }
	    else if (numReal >=100 )
        {
            string strForHunderds = "";
	        switch (numForHundreds) {
	            case 1: strForHunderds = "One hundred"; break;
	            case 2: strForHunderds = "Two hundred"; break;
	            case 3: strForHunderds = "Three hundred"; break;
	            case 4: strForHunderds = "Four hundred"; break;
	            case 5: strForHunderds = "Five hundred"; break;
	            case 6: strForHunderds = "Six hundred"; break;
	            case 7: strForHunderds = "Seven hundred"; break;
	            case 8: strForHunderds = "Eight hundred"; break;
	            case 9: strForHunderds = "Nine hundred"; break;
	        }
	        if (numForTens >= 2)
            {
                string strForTens = "";
	            switch (numForTens) 
                {
	                case 2: strForTens = "twenty"; break;
	                case 3: strForTens = "thirty"; break;
	                case 4: strForTens = "fourty"; break;
	                case 5: strForTens = "fifty"; break;
	                case 6: strForTens = "sixty"; break;
	                case 7: strForTens = "seventy"; break;
	                case 8: strForTens = "eighty"; break;
	                case 9: strForTens = "ninety"; break;
                }
                string strForOnes = "";
	            switch (numForOnes)
                {
                    case 0: strForOnes = "."; break;
                    case 1: strForOnes = "one"; break;
                    case 2: strForOnes = "two"; break;
                    case 3: strForOnes = "three"; break;
                    case 4: strForOnes = "four"; break;
                    case 5: strForOnes = "five"; break;
                    case 6: strForOnes = "six"; break;
                    case 7: strForOnes = "seven"; break;
                    case 8: strForOnes = "eight"; break;
                    case 9: strForOnes = "nine"; break;
	            }
	            Console.WriteLine(numReal + " --> " + strForHunderds + " and " + strForTens + strForOnes);
	        }
	        else if (numForTens == 1) 
            {
                string strFor10to19 = "";
	            switch (numForOnes) {
	                case 0: strFor10to19 = "ten"; break;
	                case 1: strFor10to19 = "eleven"; break;
	                case 2: strFor10to19 = "twelve"; break;
	                case 3: strFor10to19 = "threeteen"; break;
	                case 4: strFor10to19 = "fourteen"; break;
	                case 5: strFor10to19 = "fiveteen"; break;
	                case 6: strFor10to19 = "sixteen"; break;
	                case 7: strFor10to19 = "seventeen"; break;
	                case 8: strFor10to19 = "eightteen"; break;
	                case 9: strFor10to19 = "nineteen"; break;
	            }
	            Console.WriteLine(numReal + " --> " + strForHunderds + " and " + strFor10to19);
	        }
            else if (numForTens == 0)
            {
                string strForOnes = "";
	            switch (numForOnes) 
                {
                    case 0: strForOnes = "."; break;
                    case 1: strForOnes = "one"; break;
                    case 2: strForOnes = "two"; break;
                    case 3: strForOnes = "three"; break;
                    case 4: strForOnes = "four"; break;
                    case 5: strForOnes = "five"; break;
                    case 6: strForOnes = "six"; break;
                    case 7: strForOnes = "seven"; break;
                    case 8: strForOnes = "eight"; break;
                    case 9: strForOnes = "nine"; break;
	            }
                Console.WriteLine(numReal + " --> " + strForHunderds + " and " + strForOnes);
	        }
	    }
    }
}
