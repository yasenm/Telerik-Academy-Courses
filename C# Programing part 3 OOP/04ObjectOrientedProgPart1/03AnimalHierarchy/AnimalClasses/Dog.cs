using System;

public class Dog : Animal
{
    public Dog(string name, int age, Gender sex = Gender.Male) : base(name, age, sex)
    {
    }

    public override void Sounds()
    {
        Console.WriteLine("Wof wof wof! I'm a bad dog named {0}!", this.Name);
    }
}
