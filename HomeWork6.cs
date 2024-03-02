using System;

public class Professor
{
    private string profName;
    private string classTeach;
    private double salary;

    public Professor(string name, string course, double initialSalary)
    {
        profName = name;
        classTeach = course;
        salary = initialSalary;
    }

    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }

    public string GetName()
    {
        return profName;
    }

    public string GetClassTeach()
    {
        return classTeach;
    }
}

public class Student
{
    private string studentName;
    private string classEnroll;
    private double studentGrade;

    public Student(string name, string course, double grade)
    {
        studentName = name;
        classEnroll = course;
        studentGrade = grade;
    }

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }

    public string GetName()
    {
        return studentName;
    }

    public string GetClassEnroll()
    {
        return classEnroll;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Professor professor1 = new Professor("Alice", "Java", 9000);
        Professor professor2 = new Professor("Bob", "Math", 8000);

        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);

        Console.WriteLine($"Professor {professor1.GetName()} teaches {professor1.GetClassTeach()}, and the salary is: {professor1.GetSalary()}");
        Console.WriteLine($"Professor {professor2.GetName()} teaches {professor2.GetClassTeach()}, and the salary is: {professor2.GetSalary()}");

        Console.WriteLine($"Student {student1.GetName()} enrolls {student1.GetClassEnroll()}, and the grade is: {student1.GetGrade()}");
        Console.WriteLine($"Student {student2.GetName()} enrolls {student2.GetClassEnroll()}, and the grade is: {student2.GetGrade()}");

        double salaryDifference = professor1.GetSalary() - professor2.GetSalary();
        Console.WriteLine($"The salary difference between {professor1.GetName()} and {professor2.GetName()} is: {salaryDifference}");

        double totalGradeJava = student1.GetClassEnroll() == "Java" ? student1.GetGrade() : 0;
        double totalGradeMath = student2.GetClassEnroll() == "Math" ? student2.GetGrade() : 0;
        Console.WriteLine($"Total grade of {student1.GetName()} and {student2.GetName()} is: {totalGradeJava + totalGradeMath}");
    }
}
