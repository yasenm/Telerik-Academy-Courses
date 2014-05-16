using System;
using System.Collections.Generic;

public static class Extensions
{
    // we add where T : : IComparable<T> because if it is comparable it is also addable which we need
    public static dynamic Sum<T>(this IEnumerable<T> enumeration) where T : IComparable<T>
    {
        dynamic result = default(T);
        foreach (var item in enumeration)
        {
            result += item;
        }
        return result;
    }

    public static dynamic Product<T>(this IEnumerable<T> enumeration) where T : IComparable<T>
    {
        dynamic result = 1;
        foreach (var item in enumeration)
        {
            result *= item;
        }
        return result;
    }

    public static dynamic Min<T>(this IEnumerable<T> enumeration) where T : IComparable<T>
    {
        dynamic result = default(T);
        foreach (var item in enumeration)
        {
            if (result > item)
            {
                result = item;
            }
            else if(result == default(T))
            {
                result = item;
            }
        }
        return result;
    }

    public static dynamic Max<T>(this IEnumerable<T> enumeration) where T : IComparable<T>
    {
        dynamic result = default(T);
        foreach (var item in enumeration)
        {
            if (result < item)
            {
                result = item;
            }
            else if (result == default(T))
            {
                result = item;
            }
        }
        return result;
    }

    public static dynamic Avarage<T>(this IEnumerable<T> enumeration) where T : IComparable<T>
    {
        dynamic result = default(T);
        int counter = 0;
        foreach (var item in enumeration)
        {
            counter++;
            result += item;
        }
        return result / counter;
    }
}
