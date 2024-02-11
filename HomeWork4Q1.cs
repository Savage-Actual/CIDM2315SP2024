using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number (A): ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number (B): ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int largestNumber = FindLargestNumber(number1, number2);

        Console.WriteLine("A = {0}; B = {1}", number1, number2);

        Console.WriteLine("The largest number is: {2}", number1, number2, largestNumber);
    }

    static int FindLargestNumber(int num1, int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }
}