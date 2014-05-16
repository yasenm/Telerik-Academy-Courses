using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OffsiteCourse : Course, IOffsiteCourse
{
    public string Town { get; set; }

    public OffsiteCourse(string name, ITeacher teacher, string town)
    {
        this.Name = name;
        this.Teacher = teacher;
        this.Town = town;
    }

    public override string ToString()
    {
        return base.ToString() + " Town=" + this.Town + ";";
    }
}
