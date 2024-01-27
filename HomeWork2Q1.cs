using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a letter grade: ");
        char grade = Console.ReadLine().ToUpper()[0];

        int gpaPoints;

        if (grade == 'A')
        {
            gpaPoints = 4;
        }
        else if (grade == 'B')
        {
            gpaPoints = 3;
        }
        else if (grade == 'C')
        {
            gpaPoints = 2;
        }
        else if (grade == 'D')
        {
            gpaPoints = 1;
        }
        else if (grade == 'F')
        {
            gpaPoints = 0;
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
            return;
        }

        Console.WriteLine($"GPA Points: {gpaPoints}");
    }
}