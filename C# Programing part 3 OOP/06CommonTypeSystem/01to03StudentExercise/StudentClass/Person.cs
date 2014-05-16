using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Person
{
    public string FirstName { get; private set; }
    public string SecondName { get; private set; }
    public string LastName { get; private set; }

    public Person(string firstName, string secondName, string lastName)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
        this.LastName = lastName;
    }
}
