using System;
using System.Collections.Generic;
using System.Linq;

public static class Extensions
{
    // So i made those extensions with return List<> cause when i tried with void and changing the inputed
    // List<> it broke for some reason will like to get a feedback on this cause would like to  use
    // instance.OrderByGrade() instead of instance = instance.OrderByGrade() that also applyes for the
    // next 3 methods afte that one thanks in advance
    public static List<Student> OrderByGrade(this List<Student> students)
    {
        var result =
            from student in students
            orderby student.Grade, student.FirstName
            select student;
        return result.ToList();
    }

    public static List<Student> OrderByName(this List<Student> students)
    {
        var result =
            from student in students
            orderby student.FirstName, student.LastName
            select student;
        return result.ToList();
    }


    public static List<Worker> OrderBySalary(this List<Worker> workers)
    {
        var result =
            from worker in workers
            orderby worker.SalaryPerHour, worker.FirstName
            select worker;
        return result.ToList();
    }

    public static List<Worker> OrderByName(this List<Worker> workers)
    {
        var result =
            from worker in workers
            orderby worker.FirstName, worker.LastName
            select worker;
        return result.ToList();
    }

    // Extension method to print a whole Enumerable collection made generic
    public static void PrintEnum<T>(this IEnumerable<T> enumeration) 
    {
        foreach (var item in enumeration)
        {
            Console.WriteLine(item);
        }
    }
}
