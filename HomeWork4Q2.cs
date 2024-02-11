using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter a number: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a direction (left/right): ");
        string direction = Console.ReadLine();
 
        MakeShape(N, direction);
    }

    static void MakeShape(int N, string direction)
    {
        Console.WriteLine("N is: {0}; Shape is {1}", N, direction);

        if (direction == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        else if (direction == "right")
        {
            
            for (int i = 1; i <= N; i++)
            {
                
                for (int k = 1; k <= N - i; k++)
                {
                    Console.Write("  ");
                }

                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}