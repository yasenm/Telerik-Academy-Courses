using System;

// Student inherits the two main properties from the fakt that is a Person
public class Student : Person
{
    private int classNumber;

    // Made a check if a student gets bigger classnumber than 50 to throw exception since there cant be more than
    // 50 students in one class as i decided to put that constraint
    private int ClassNumber
    {
        get
        {
            return this.classNumber;
        }
        set
        {
            if (value < 0 || value > 50)
            {
                throw new ArgumentOutOfRangeException("Class already full!");
            }
            this.classNumber = value;
        }
    }

    // two constructors made for initializing a Student
    public Student(string name, int age) : base(name, age)
    {
    }

    public Student(string name, int age, int classNumber = 0) : base(name, age)
    {
        this.ClassNumber = classNumber;
    }

    public override string ToString()
    {
        string result = String.Format("Student name : {0}\n", this.Name);
        result += String.Format("Unique class number : {0}\n", this.ClassNumber);
        return result;
    }
}
