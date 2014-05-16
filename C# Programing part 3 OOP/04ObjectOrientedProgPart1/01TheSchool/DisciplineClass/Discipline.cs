using System;

// A public class that each object from whom contains the main parameters for a teached discipline
// name of discipline, number of lectures and number of exercises and gives us object that contains that information
public class Discipline
{
    public Disciplines NameOfDiscipline { get; private set; }
    public int NumberOfLectures { get; private set; }
    public int NumberOfExercises { get; private set; }

    public Discipline(Disciplines discipline, int numberOfLectures, int numberOfExercises) 
    {
        this.NameOfDiscipline = discipline;
        this.NumberOfLectures = numberOfLectures;
        this.NumberOfExercises = numberOfExercises;
    }
}