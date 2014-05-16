using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student : Person, ICloneable, IComparable<Student>
{
    public string SSN = "unknown";
    public string PermanentAddress = "unknown";
    public string PhoneNumber = "unknown";
    public string EMail = "unknown";
    public int Course = 1;
    public Faculty facultyOfStudent = Faculty.Unknown;
    public Speciality specialityOfStudent = Speciality.Unknown;
    public University universityOfStudent = University.Unknown;
    
    public Student(string firstName, string secondName, string lastName) : base(firstName,secondName,lastName) 
    {
    }


    public Student(string firstName, string secondName, string lastName, string ssn, string permanentAddress, string phoneNumber, string eMail, int course) : base(firstName, secondName, lastName)
    {
        this.SSN = ssn;
        this.PermanentAddress = permanentAddress;
        this.PhoneNumber = phoneNumber;
        this.EMail = eMail;
        this.Course = course;
    }

    internal void FacultyOfStudent(Faculty faculty)
    {
        this.facultyOfStudent = faculty;
    }

    internal void SpecialityOfStudent(Speciality speciality)
    {
        this.specialityOfStudent = speciality;
    }

    internal void UniversityOfStudent(University university)
    {
        this.universityOfStudent = university;
    }

    #region Exercise 01 Part
    public override bool Equals(object obj)
    {
        if (!(obj is Student))
        {
            return false;
        }

        // take the obj and cast it to Student
        Student student = obj as Student;

        // Compare the reference type members
        if (!Object.Equals(this.FirstName, student.FirstName) 
            || !Object.Equals(this.SecondName, student.SecondName)
            || !Object.Equals(this.LastName, student.LastName)
            || !Object.Equals(this.SSN, student.SSN)
            || !Object.Equals(this.PermanentAddress, student.PermanentAddress)
            || !Object.Equals(this.PhoneNumber, student.PhoneNumber)
            || !Object.Equals(this.EMail, student.EMail))
        {
            return false;
        }

        // compare the value type member fields
        if ( this.Course != student.Course
            || this.facultyOfStudent != student.facultyOfStudent
            || this.specialityOfStudent != student.specialityOfStudent
            || this.universityOfStudent != student.universityOfStudent)
        {
            return false;
        }

        return true;
    }

    public static bool operator ==(Student student1, Student student2)
    {
        return Student.Equals(student1, student2);
    }

    public static bool operator !=(Student student1, Student student2)
    {
        return !Student.Equals(student1, student2);
    }

    public override int GetHashCode()
    {
        return this.FirstName.GetHashCode() ^ this.SecondName.GetHashCode() ^ this.LastName.GetHashCode();
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append("------ STUDENT ------\n");
        result.Append(String.Format("Name : {0} {1} {2};\n", this.FirstName, this.SecondName, this.LastName));
        result.Append(String.Format("SSN : {0}; Course : {1};\n", this.SSN, this.Course));
        result.Append(String.Format("Permanent address : {0};\n", this.PermanentAddress));
        result.Append(String.Format("Phone number : {0}; e-mail : {1};\n", this.PhoneNumber, this.EMail));
        result.Append(String.Format("University : {0}; Faculty : {1}; Speciality : {2};\n", this.universityOfStudent, this.facultyOfStudent, this.specialityOfStudent));
        return result.ToString();
    }
    #endregion

    #region Exercise 02 Part
    public object Clone()
    {
        Student student = new Student(String.Copy(this.FirstName), String.Copy(this.SecondName), String.Copy(this.LastName),
            String.Copy(this.SSN), String.Copy(this.PermanentAddress), String.Copy(this.PhoneNumber), String.Copy(this.EMail), this.Course);
        student.FacultyOfStudent(this.facultyOfStudent);
        student.SpecialityOfStudent(this.specialityOfStudent);
        student.UniversityOfStudent(this.universityOfStudent);

        return student;
    }
    #endregion

    #region Exercise 03 Part
    public int CompareTo(Student otherStudent)
    {
        if (this.FirstName.CompareTo(otherStudent.FirstName) < 0)
        {
            return -1;
        }
        else if (this.FirstName.CompareTo(otherStudent.FirstName) > 0)
        {
            return 1;
        }
        else
        {
            if (this.SecondName.CompareTo(otherStudent.SecondName) < 0)
            {
                return -1;
            }
            else if (this.SecondName.CompareTo(otherStudent.SecondName) > 0)
            {
                return 1;
            }
            else
            {
                if (this.LastName.CompareTo(otherStudent.LastName) < 0)
                {
                    return -1;
                }
                if (this.LastName.CompareTo(otherStudent.LastName) > 0)
                {
                    return 1;
                }
            }
        }

        if (this.SSN.CompareTo(otherStudent.SSN) < 0)
        {
            return -1;
        }
        else if (this.SSN.CompareTo(otherStudent.SSN) > 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    #endregion
}
