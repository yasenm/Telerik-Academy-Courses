using System;

// Student class inherits the Human with its two parameters
public class Student : Human
{
    // thats a private double made because otherwise without the private set for double Grade
    // gave StackOverflowException and a friend told that litle trick
    private double grade;

    public double Grade 
    { 
        get
        {
            return this.grade;
        }
        private set 
        {
            if (value < 2.00 || value > 6.00)
            {
                throw new IndexOutOfRangeException("There can't be a grade lesser than 2.00 or bigger than 6.00!");
            }
            this.grade = value;
        }
    }

    // decided to make one constructor as in the specification is said that every Student has one if not entered than he is a "dvoikar/ka"
    public Student(string firstName, string lastName, double grade = 2) : base(firstName, lastName)
    {
        this.Grade = grade;
    }

    // overrided ToString() for the purposes of easy printing for the Student class
    public override string ToString()
    {
        string result = String.Format("Grade : {0,5} - Student - {1} {2}", this.Grade, this.FirstName, this.LastName);
        return result;
    }
}
