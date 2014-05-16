// Exercise 01 : Define a class Student, which contains data about a student – first, middle
// and last name, SSN, permanent address, mobile phone, e-mail, course, specialty,
// university, faculty. Use an enumeration for the specialties, universities and
// faculties. Override the standard methods, inherited by  System.Object: Equals(),
// ToString(), GetHashCode() and operators == and !=.

// Exercise 02 : Add implementations of the ICloneable interface. The Clone() method should deeply copy
// all object's fields into a new object of type Student.

// Exercise 03 : Implement the  IComparable<Student> interface to compare students by names (as first criteria,
// in lexicographic order) and by social security number (as second criteria, in increasing order).

namespace _01to03StudentExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StudentExercise
    {
        static void Main()
        {
            Student someStudent = new Student("Pesho", "Petkov", "Petkov");
            Console.WriteLine(someStudent);

            Student someOtherStudent = new Student("Pesho", "Petkov", "Petkov");

            Console.WriteLine("Test for equals : {0}", someStudent.Equals(someOtherStudent));
            Console.WriteLine();

            someStudent.UniversityOfStudent(University.TU_Sofia);
            Console.WriteLine("Test for equals with changed university : {0}",someStudent.Equals(someOtherStudent));
            Console.WriteLine();

            Student anotherStudent = someStudent.Clone() as Student;
            anotherStudent.EMail = "TypiqPesho@yahoo.com";
            Console.WriteLine("After using clone the result : ");
            Console.WriteLine(anotherStudent);

            Console.WriteLine("Comparing first student with cloned one : {0}", someStudent.CompareTo(anotherStudent));
            Student someStudent2 = new Student("Pesha", "Petkov", "Petkov");
            Console.WriteLine("Comparing first student with new student : {0}", someStudent.CompareTo(someStudent2));
        }
    }
}
