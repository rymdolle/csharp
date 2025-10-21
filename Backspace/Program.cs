using System;
class Program
{
    public static void Main(string[] args)
    {
        char[] output = new char[10_000_000];
        int position = 0;
        int c;
        while ((c = Console.Read()) >= 0)
        {
            if (c == '<')
            {
                --position;
            }
            else
            {
                output[position] = (char)c;
                position++;
            }
        }

        Console.WriteLine(output, 0, position - 1);
    }
}
