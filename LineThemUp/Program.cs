using System;
class Program
{
    public static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine()!);
        string a = Console.ReadLine()!;
        string b = Console.ReadLine()!;
        int direction = a.CompareTo(b);
        for (int i = 2; i < count; i++)
        {
            a = b;
            b = Console.ReadLine()!;
            if (a.CompareTo(b) != direction)
            {
                Console.WriteLine("NEITHER");
                return;
            }
        }
        Console.WriteLine(direction < 0 ? "INCREASING" : "DECREASING");
    }
}
