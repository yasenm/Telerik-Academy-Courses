// Exercise 03 : Write a method that from a given array of students finds
// all students whose first name is before its last name alphabetically.
// Use LINQ query operators.

// Exercise 04 : Write a LINQ query that finds the first name and last 
// name of all students with age between 18 and 24.

// Exercise 05 : Using the extension methods OrderBy() and ThenBy() with
// lambda expressions sort the students by first name and last name in
// descending order. Rewrite the same with LINQ.

namespace _03to05StudentsExercises
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public delegate List<Student> GetEnumFromNames(Student[] enumeration);

    class StudentsExercises
    {
        // The student class is defined in the filder StudentClass in the .cs file
        static void Main()
        {
            Student[] students = 
            {
                new Student("Pesho", "Petkov", 15),
                new Student("Haralampi", "Ivanov", 18),
                new Student("Gosho", "Petkov", 26),
                new Student("Mariq", "Haralampieva", 24),
                new Student("Cecka", "Pecka", 17),
                new Student("Ivan", "Ivanov", 22),
                new Student("Ivan", "Petkov", 30),
                new Student("Ivan", "Geshev", 30),
                new Student("Typi", "Typov", 30),
                new Student("Typata", "Pacha", 21)
            };

            // Exercise 03 : Implemented with delegate variable = method The method we us is ExtractNames() from methods afer the Main()
            GetEnumFromNames findAlphabeticalNames = new GetEnumFromNames(ExtractNames);
            var names = findAlphabeticalNames(students);
            Console.WriteLine("Found all names which first name is alphabeticaly before last name of student :");
            foreach (var item in names)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            Console.WriteLine();

            // Exercise 04 : Implemented with delegate variable = method The method we us is GetAllStudentFromAge() from methods afer the Main()
            Console.WriteLine("The students between 18 and 24 in age are : ");
            GetEnumFromNames findAllInAgeDiapason = new GetEnumFromNames(GetAllStudentFromAge);
            foreach (var student in findAllInAgeDiapason(students))
            {
                Console.WriteLine("Age : {0,3}; First name : {1,15}; Last name : {2,15};", student.Age, student.FirstName, student.LastName);
            }
            Console.WriteLine();

            // Exercise 05 : Using lambda
            // expressions sortBy() and ThenBy() sorting the array by first name and then by last name 
            var sortedByFirstName = students.OrderBy(student => student.FirstName).ThenBy(student => student.LastName);
            Console.WriteLine("Using lambda! Sorted by first name : ");
            foreach (var student in sortedByFirstName)
            {
                Console.WriteLine("Student | {0} {1};", student.FirstName, student.LastName);
            }
            Console.WriteLine();

            // Exercise 05 : Rewriten with LINQ
            var sortedByFirstNameSecondEdition =
                from student in students
                orderby student.FirstName,  student.LastName
                select student;
            Console.WriteLine("Using LINQ expression! Sorted by first name : ");
            foreach (var student in sortedByFirstNameSecondEdition)
            {
                Console.WriteLine("Student | {0} {1};", student.FirstName, student.LastName);
            }
            Console.WriteLine();
        }

        // Ex. 03 method
        static List<Student> ExtractNames(Student[] students) 
        {
            var result =
                from student in students
                where (student.FirstName.CompareTo(student.LastName) == -1)
                select student;
            return result.ToList();
        }

        // Ex. 03 method
        static List<Student> GetAllStudentFromAge(Student[] students) 
        {
            var result =
                from student in students
                where (student.Age >= 18 && student.Age <= 24)
                select student;
            return result.ToList();
        }

    }
}
