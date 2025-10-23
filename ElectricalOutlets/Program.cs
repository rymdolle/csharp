using System;
class Program
{
    public static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < count; i++)
        {
            string line = Console.ReadLine()!;
            string[] cords = line.Split(' ')[1..];
            int ports = 1;
            foreach (string cord in cords)
            {
                ports += int.Parse(cord) - 1;
            }
            Console.WriteLine(ports);
        }
    }
}
