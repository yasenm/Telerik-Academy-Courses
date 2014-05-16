using System;

public abstract class Animal : ISound
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public Gender Sex { get; set; }

    public Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public Animal(string name, int age, Gender sex = Gender.SomethingInBetween)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    public virtual void Sounds()
    {
    }
}