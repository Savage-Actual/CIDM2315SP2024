using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number (A): ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number (B): ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number (C): ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the forth number (D): ");
        int number4 = Convert.ToInt32(Console.ReadLine());

        int largestNumber = FindLargestNumber(number1, number2, number3, number4);

        Console.WriteLine("A = {0}; B = {1}; C = {2}; D = {3}", number1, number2, number3, number4);

        Console.WriteLine($"The largest number is: {largestNumber}");
    }

    static int FindLargestNumber(int a, int b, int c, int d)
    {
        int largest = a;

        if (b > largest)
        {
            largest = b;
        }

        if (c > largest)
        {
            largest = c;
        }

        if (d > largest)
        {
            largest = d;
        }

        return largest;
    }
}
