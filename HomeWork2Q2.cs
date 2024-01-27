namespace HomeWork2Q2;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("Please input the first number: ");
      int first = Convert.ToInt16(Console.ReadLine());  

      Console.Write("Please input the second number: ");
      int second = Convert.ToInt16(Console.ReadLine());

      Console.Write("Please input the third number: ");
      int third = Convert.ToInt16(Console.ReadLine());

      int smallest = Smallest(first, second, third);

      Console.WriteLine($"The smallest value is: {smallest}");
    }
     static int Smallest(int a, int b, int c)
    {
        if (a <= b && a <= c)
        {
            return a;
        }
        else if (b <= a && b <= c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }
}



