using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LocalCourse : Course, ILocalCourse
{
    public string Lab { get; set; }

    public LocalCourse(string name, ITeacher teacher, string lab)
    {
        this.Name = name;
        this.Teacher = teacher;
        this.Lab = lab;
    }

    public override string ToString()
    {
        return base.ToString() + " Lab=" + this.Lab + ";";
    }
}
