using System;

public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
    }

    public Cat(string name, int age, Gender sex = Gender.SomethingInBetween) : base(name, age, sex)
    {
    }

    public override void Sounds()
    {
        Console.WriteLine("Meow meow! I'm a poor cat and my name is {0}!", this.Name);
    }
}
