using System;

public class Frog : Animal
{
    public Frog(string name, int age, Gender sex = Gender.It) : base(name, age, sex)
    {
    }

    public override void Sounds()
    {
        Console.WriteLine("Kwak kwak kwak! I'm a green from and my name {0}!", this.Name);
    }
}
