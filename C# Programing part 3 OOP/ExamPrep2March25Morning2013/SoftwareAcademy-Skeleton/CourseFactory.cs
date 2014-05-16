using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CourseFactory : ICourseFactory
{
    public ITeacher CreateTeacher(string name)
    {
        Teacher createdTeacher = new Teacher();
        createdTeacher.Name = name;
        return createdTeacher;
    }

    public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
    {
        return new LocalCourse(name, teacher, lab);
    }

    public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
    {
        return new OffsiteCourse(name, teacher, town);
    }
}
