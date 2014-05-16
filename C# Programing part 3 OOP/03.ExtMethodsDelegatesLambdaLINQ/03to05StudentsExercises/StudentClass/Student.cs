// defining the class Student and its constructor for the purposes of the 
// exercises

using System;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Student(string firstName, string lastName, int age) 
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }
}
