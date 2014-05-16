// Exercise 02 : Define abstract class Human with first name and last name. Define new
// class Student which is derived from Human and has new field – grade.
// Define class Worker derived from Human with new property WeekSalary
// and WorkHoursPerDay and method MoneyPerHour() that returns money earned
// by hour by the worker. Define the proper constructors and properties for
// this hierarchy. Initialize a list of 10 students and sort them by grade 
// in ascending order (use LINQ or OrderBy() extension method). Initialize a
// list of 10 workers and sort them by money per hour in descending order.
// Merge the lists and sort them by first name and last name.


namespace _02TheHumanExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TheHumanExercise
    {
        static void Main()
        {
            // List of students made
            List<Student> classOfStudents = new List<Student>();
            classOfStudents.Add(new Student("Typata", "Pacha", 2.05));
            classOfStudents.Add(new Student("Typata", "Putka"));
            classOfStudents.Add(new Student("Lainomet", "Driskov", 2.80));
            classOfStudents.Add(new Student("Ivan", "Ivanov", 4.00));
            classOfStudents.Add(new Student("Georgi", "Georgiev", 5.65));
            classOfStudents.Add(new Student("Angel", "Angelov", 6.00));
            classOfStudents.Add(new Student("Petyr", "Petrov", 3.65));
            classOfStudents.Add(new Student("Prosti", "Prostev", 3.00));
            classOfStudents.Add(new Student("Kurti", "Kurtev", 5.65));
            classOfStudents.Add(new Student("Ivan", "Georgiev", 4.00));
            classOfStudents.Add(new Student("Putko", "Ma fani", 4.00));

            // both of the next two methods are made as extensions in the folder extensions in the same name file.cs
            // for more easy use of the methods by my opignion
            Console.WriteLine("Sorted list of students by their grades : \n");
            // First sorted by grade
            classOfStudents = classOfStudents.OrderByGrade();
            classOfStudents.PrintEnum();
            Console.WriteLine("\n");

            Console.WriteLine("Sorted list of students by names : \n");
            // Second sorted by name
            classOfStudents = classOfStudents.OrderByName();
            classOfStudents.PrintEnum();
            Console.WriteLine("\n");

            // List of workers made for the purposes of exercise
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Bai", "Pesho", 500, 8));
            workers.Add(new Worker("Pesho", "Cifkata", 240.80, 7.5));
            workers.Add(new Worker("Penio", "Teslata", 300, 8));
            workers.Add(new Worker("Ivan", "Pechkata", 500, 8));
            workers.Add(new Worker("Ivan", "Ivanov", 500, 8));
            workers.Add(new Worker("Ivan", "Sekirata", 500, 8));
            workers.Add(new Worker("Bai", "Gosho", 400, 8));
            workers.Add(new Worker("Joro", "Motikata", 600, 8));
            workers.Add(new Worker("Typi", "Typev", 1000, 8));
            workers.Add(new Worker("Bai", "Ivan", 1500, 8));
            workers.Add(new Worker("Koce", "Kocev", 100, 8));
            workers.Add(new Worker("Kurti", "Kurtev", 0, 8));

            // both of the next two methods are made as extensions in the folder extensions in the same name file.cs
            // for more easy use of the methods by my opignion
            Console.WriteLine("Sorted list of workers by their money per hour : \n");
            // First sorted by salary per hour check both ways
            // - by using my extension methods
            workers = workers.OrderBySalary();
            //// - by using a simple LINQ expression
            //workers = workers.OrderBy(w => w.SalaryPerHour).ToList();
            workers.PrintEnum();
            Console.WriteLine("\n");

            Console.WriteLine("Sorted list of workers by name : \n");
            // Second sorted by names
            workers = workers.OrderByName();
            workers.PrintEnum();
            Console.WriteLine("\n");
        }
    }
}
