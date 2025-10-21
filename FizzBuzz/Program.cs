using System;
class Program
{
    public static void Main(string[] args)
    {
        string? line = Console.ReadLine();
        if (line == null) return;
        string[] input = line.Split(' ');
        int x = Int32.Parse(input[0]);
        int y = Int32.Parse(input[1]);
        int n = Int32.Parse(input[2]);

        for (int i = 1; i <= n; ++i)
        {
            if (i % x == 0 && i % y == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % x == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % y == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
