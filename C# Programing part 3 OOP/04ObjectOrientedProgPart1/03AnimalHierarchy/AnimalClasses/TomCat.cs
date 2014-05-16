using System;

public class TomCat : Cat
{
    public TomCat(string name, int age) : base(name, age)
    {
        this.Sex = Gender.Male;
    }

    public override void Sounds()
    {
        Console.WriteLine("Meow meow! I'm a big tomcat and my name is {0}!", this.Name);
    }
}