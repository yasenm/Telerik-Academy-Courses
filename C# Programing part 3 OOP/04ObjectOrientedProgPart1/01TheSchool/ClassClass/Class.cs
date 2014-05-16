using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;


// The class Class that contains in it self text identifier (name of class "A class" , "B class" and etc.) and contains two lists one of
// the teachers that teach this class and one of the students that are in this Class
public class Class
{
    // Each class can have maximum of 8 teachers
    private const int MaxTeachersCount = 8;

    // Each class can have maximum of 50 students
    private const int MaxStudentCount = 50;
    public string TextIdentifier { get; private set; }

    public Class(string textIdentifier) 
    {
        this.TextIdentifier = textIdentifier;
    }

    // the two lists of teachers and students in the Class
    private List<Teacher> teachers = new List<Teacher>();
    private List<Student> students = new List<Student>();

    // First method that gives us opertunity to add teacher that teaches the students
    public void AddTeacher(Teacher teacher) 
    {
        teachers.Add(teacher);
    }

    // First method that gives us opertunity to add Student to the class
    public void AddNewStudentToClass(Student student) 
    {
        students.Add(student);
        // whenever a student or students are added we order them by name and give them their new unique classnumbers
        // since in Classes in schools as i know thats the way of organizing atleast thats how i did it ;)
        OrderClassAlphabeticaly();
    }

    // Second method that gives us opertunity to add a IEnumerable<Students> to the list more than one
    public void AddENumerableStudentsToClass(IEnumerable<Student> newStudents) 
    {
        foreach (var student in newStudents)
        {
            students.Add(student);
        }
        // whenever a student or students are added we order them by name and give them their new unique classnumbers
        // since in Classes in schools as i know thats the way of organizing atleast thats how i did it ;)
        OrderClassAlphabeticaly();
    }

    // method that orders the class alphabeticaly and after that gives each student their unique class number
    private void OrderClassAlphabeticaly() 
    {
        // makes ordered list 
        var orderedStudents = this.students.OrderBy(student => student.Name).ToList();

        // counter that gives each student his classnumber
        int classNumberCounter = 1;

        //clears old list
        this.students.Clear();

        // adds new sorted enumerable to the list of students
        foreach (var student in orderedStudents)
        {
            this.students.Add(new Student(student.Name, student.Age, classNumberCounter));
            classNumberCounter++;
        }
    }

    // by overriding ToString() collects all the information for one Class and returns it as a string
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append(String.Format("This is {0}\n", this.TextIdentifier));
        result.Append("\nTeachers :\n\n");
        foreach (var teacher in teachers)
        {
            result.Append(teacher.ToString());
        }
        result.Append("\nStudents in class : \n\n");
        foreach (var student in students)
        {
            result.Append(student.ToString());
        }
        return result.ToString();
    }
}
