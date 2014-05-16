using System;

public class Kitten : Cat
{
    public Kitten(string name, int age) : base(name, age)
    {
        this.Sex = Gender.Female;
    }

    public override void Sounds()
    {
        Console.WriteLine("Meowwww meowww meowwwwwwwwwwwwwwww! Im just a little kitten and my name is {0}!", this.Name); ;
    }
}