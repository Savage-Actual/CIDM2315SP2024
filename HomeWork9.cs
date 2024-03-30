using System;
using System.Collections.Generic;

public class Student
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    public static int GetStudentID(string studentName)
    {
        foreach (var student in studentList)
        {
            if (student.studentName == studentName)
            {
                return student.studentID;
            }
        }
        return -1;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Student student1 = new Student(111, "Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(333, "Cathy");
        Student student4 = new Student(444, "David");
        Student student5 = new Student(555, "Tom");

        Dictionary<string, double> gradebook = new Dictionary<string, double>()
        {
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8},
            {"Tom", 3.3}
        };

        double totalGPA = 0;
        foreach (var gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / gradebook.Count;

        Console.WriteLine($"The average GPA is {averageGPA}");

        Console.WriteLine("Students with GPA greater than average:");
        foreach (var pair in gradebook)
        {
            if (pair.Value > averageGPA)
            {
                Console.WriteLine($"Student ID: {Student.GetStudentID(pair.Key)}, Student Name: {pair.Key}");
            }
        }
    }
}
