using System;

class Program
{
    static void Main()
    {
        Console.Write("Assign an int value to N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            NoNegatives(n);
        }
        else
        {
            Console.WriteLine("Assign a positive int value to N.");
        }
    }

    static void NoNegatives(int size)
    {
        for (int c = 1; c <= size; c++)
        {
            for (int r = 1; r <= c; r++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}


