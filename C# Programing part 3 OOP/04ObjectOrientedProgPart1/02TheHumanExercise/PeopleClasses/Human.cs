using System;

// As in the specifications in the exercise made abstract Human class with two main properties FirstName and LastName
// which the Student and Worker class will inherit
public abstract class Human
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public Human(string firstName, string lastName)
    {
        // TODO: Complete member initialization
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}
