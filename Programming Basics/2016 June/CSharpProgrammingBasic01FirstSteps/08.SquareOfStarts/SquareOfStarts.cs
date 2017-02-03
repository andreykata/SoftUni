using System;

class SquareOfStarts
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var stars = new string('*', n);
        Console.WriteLine(stars);

        for (int i = 0; i < n - 2; i++)
        {
            var line = "*" + new string(' ', n - 2) + "*";
            Console.WriteLine(line);
        }

        Console.WriteLine(stars);
    }
}