using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TestPersonClass
{
    public static void Test() 
    {
        Person[] people = {
            new Person("Person1", 18),
            new Person("Person2", 26),
            new Person("Person3", 80),
            new Person("Person4", 11),
            new Person("Person5", 33),
            new Person("Person6", 45),
        };

        for (int i = 0; i < people.Length; i++)
        {
            Console.WriteLine("Test {0} : ", i);
            TestPersonTostring(people[i]);
        }
    }

    private static void TestPersonTostring(Person person) 
    {
        Console.WriteLine(person);
    }
}