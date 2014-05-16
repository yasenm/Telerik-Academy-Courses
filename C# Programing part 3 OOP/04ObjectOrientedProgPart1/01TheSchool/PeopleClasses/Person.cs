using System;

// Main parrent class made Person that will give every other class that inherits him the two main parameters for a person
// a Name and Age that everyone of us has
public class Person
{
    public string Name { get; private set; }

    public int Age { get; private set; }

    public Person(string name, int age) 
    {
        this.Name = name;
        this.Age = age;
    }
}