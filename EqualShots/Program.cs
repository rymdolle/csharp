using System;
class Program
{
    public static void Main(string[] args)
    {
        string? line = Console.ReadLine();
        if (line == null) return;
        string[] input = line.Split(' ');
        int a = Int32.Parse(input[0]);
        int b = Int32.Parse(input[1]);

        int aTotal = alcoholContent(a);
        int bTotal = alcoholContent(b);
        Console.WriteLine(aTotal == bTotal ? "same" : "different");
    }

    private static int alcoholContent(int nLines)
    {
        int total = 0;
        for (int i = 0; i < nLines; ++i)
        {
            string? line = Console.ReadLine();
            if (line == null) continue;
            string[] input = line.Split(' ');
            int volume = Int32.Parse(input[0]);
            int percent = Int32.Parse(input[1]);
            total += volume * percent;
        }

        return total;
    }
}
