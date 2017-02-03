using System;
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var lengthUnderScores = 0;

        if (n % 2 == 0)
        {
            lengthUnderScores = (2 * n) - n - 4;
        }
        else
        {
            lengthUnderScores = (2 * n) - n - 3;
        }

        var line = "/" + new string('^', n / 2) + "\\";
        line = line + new string('_', lengthUnderScores);
        line = line + "/" + new string('^', n / 2) + "\\";
        Console.WriteLine(line);

        for (int row = 0; row < n - 3; row++)
        {
            line = "|" + new string(' ', (2 * n) - 2) + "|";
            Console.WriteLine(line);
        }

        line = "|" + new string(' ', (n / 2) + 1) + new string('_', lengthUnderScores) + new string(' ', (n / 2) + 1) + "|";
        Console.WriteLine(line);

        line = "\\" + new string('_', n / 2) + "/";
        line = line + new string(' ', lengthUnderScores);
        line = line + "\\" + new string('_', n / 2) + "/";
        Console.WriteLine(line);
        Console.WriteLine(line.Length);
    }
}
