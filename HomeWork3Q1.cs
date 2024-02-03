using System;

class Program
{
    static void Main()
    {
        Console.Write("Input an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} is prime.");
        }
        else
        {
            Console.WriteLine($"{number} is nonprime.");
        }
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}


