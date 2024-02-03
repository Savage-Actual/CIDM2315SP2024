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
        for (int c = 0; c < size; c++)
        {
            for (int r = 0; r < size; r++)
            {
                Console.Write("# ");
            }
            Console.WriteLine();
        }
    }
}


