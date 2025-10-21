using System;
class Program
{
    public static void Main(string[] args)
    {
        string? line = Console.ReadLine();
        if (line == null) return;
        string[] input = line.Split(' ');
        int n = Int32.Parse(input[0]);
        int t = Int32.Parse(input[1]);

        int[] potions = new int[n];

        for (int i = 0; i < n; ++i)
        {
            line = Console.ReadLine();
            if (line == null) return;
            potions[i] = Int32.Parse(line);
        }
        Array.Sort(potions);
        for (int i = 0; i < n; ++i)
        {
            if (i * t >= potions[i])
            {
                Console.WriteLine("NO");
                return;
            }
        }
        Console.WriteLine("YES");
    }
}
