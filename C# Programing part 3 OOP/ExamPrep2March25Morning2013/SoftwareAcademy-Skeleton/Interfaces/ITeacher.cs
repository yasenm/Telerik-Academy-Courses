using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ITeacher
{
    string Name { get; set; }
    void AddCourse(ICourse course);
    string ToString();
}