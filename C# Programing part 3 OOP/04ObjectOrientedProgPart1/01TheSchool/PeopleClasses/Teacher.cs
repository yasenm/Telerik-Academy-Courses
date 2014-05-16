using System;
using System.Collections.Generic;

// Teacher class inherits the person stats and the ITeach interface that adds discipline to the teacher profile.
public class Teacher : Person, ITeach
{
    // List that will hold all the disciplines that a teacher can teach
    List<Discipline> disciplines = new List<Discipline>();

    // made two constructors 
    public Teacher(string name, int age) : base(name, age)
    {
    }

    public Teacher(string name, int age, Discipline discipline) : base(name, age)
    {
        disciplines.Add(discipline);
    }

    // Implemented method from the interface
    public void Teach(Discipline discipline)
    {
        disciplines.Add(discipline);
    }

    // Ofcourse overrided ToString() for easy printing on console
    public override string ToString()
    {
        string result = String.Format("Teacher name : {0}\n", this.Name);
        foreach (var discipline in disciplines)
	    {
            result += String.Format("I teach : {0}.\n", discipline.NameOfDiscipline);
            result += String.Format("My number of lectures is : {0}.\n", discipline.NumberOfLectures);
            result += String.Format("My number of exercises is : {0}.\n", discipline.NumberOfExercises);
	    }
        return result;
    }
}