using System;
using System.Text;

public static class Extensions
{
    public static string Substring(this StringBuilder strB, int startIndex) 
    {
        if (startIndex < 0 || startIndex >= strB.Length)
        {
            throw new IndexOutOfRangeException("StringBuilder Substring inputed parameter is out of range!");
        }
        return strB.ToString().Substring(startIndex);
    }

    public static string Substring(this StringBuilder strB, int startIndex, int length) 
    {
        if (startIndex < 0 || startIndex >= strB.Length)
        {
            throw new IndexOutOfRangeException("StringBuilder Substring inputed parameters is out of range!");
        }
        else if (length <= 0)
        {
            throw new IndexOutOfRangeException("Length input is larger than StringBuilder length. Operation impossible!");
        }
        else if (startIndex + length > strB.Length)
        {
            throw new IndexOutOfRangeException("The two input arguments sum is larger than StringBuilder length!");
        }
        return strB.ToString().Substring(startIndex, length);
    }
}
