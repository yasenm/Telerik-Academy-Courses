using System;
using System.Collections.Generic;
using System.Linq;

public class InvalidRangeException<T> : ApplicationException
{
    public static DateTime OldestDateRelieble = new DateTime(1980, 1, 1);
    public static DateTime NewestDateRelieble = new DateTime(2013, 12, 31);

    public InvalidRangeException(string message)
        : base(message)
    {

    }
}
