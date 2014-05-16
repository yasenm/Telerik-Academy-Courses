using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Teacher : ITeacher
{
    public string name;
    public string Name 
    {
        get 
        {
            return this.name;
        }
        set 
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            this.name = value;
        }
    }

    public IList<ICourse> Courses = new List<ICourse>();

    public void AddCourse(ICourse course)
    {
        this.Courses.Add(course);
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append(String.Format("Teacher: Name={0};", this.Name));

        if (Courses.Count > 0)
        {
            result.Append(" Courses:[");
            for (int i = 0; i < this.Courses.Count; i++)
            {
                result.Append(Courses[i].Name + ", ");
            }
            result.Length -= 2;
            result.Append("];");
        }
        return result.ToString();
    }
}

