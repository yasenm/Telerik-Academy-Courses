// Exercise 01 : We are given a school. In the school there are classes of students. Each 
// class has a set of teachers. Each teacher teaches a set of disciplines.
// Students have name and unique class number. Classes have unique text
// identifier. Teachers have name. Disciplines have name, number of
// lectures and number of exercises. Both teachers and students are people.
// Students, classes, teachers and disciplines could have optional comments
// (free text block).

// Your task is to identify the classes (in terms of  OOP) and their attributes
// and operations, encapsulate their fields, define the class hierarchy and
// create a class diagram with Visual Studio.

namespace _01TheSchool
{
    using System;
    using System.Collections.Generic;

    class TheSchoolProgram
    {
        static void Main()
        {
            // A teacher instance made for tests and other things
            Teacher gospojata = new Teacher("Penka Gospodinova", 50);
            gospojata.Teach(new Discipline(Disciplines.Biology, 8, 8));
            Console.WriteLine(gospojata.ToString());

            // Class made and added with all methods students and teachers
            Class classA = new Class("A class");
            classA.AddTeacher(gospojata);
            classA.AddNewStudentToClass(new Student("Pesho Cifkata", 18));

            Student[] someNewStudents = 
            {
                new Student("Typata Pacha", 18),
                new Student("Typata Putka", 18),
                new Student("Lainomet Driskov", 18),
                new Student("Ivan Ivanov", 18),
                new Student("Georgi Georgiev", 18),
                new Student("Angel Angelov", 18),
                new Student("Petyr Petrov", 18),
            };

            // adding more than one student at a time in the class as mentioned in the class Class comenteries
            classA.AddENumerableStudentsToClass(someNewStudents);

            // Printing the overrided method ToString()
            Console.WriteLine(classA);
        }
    }
}
