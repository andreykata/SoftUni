using System;
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var middle = 0;

        if (n % 2 != 0)
        {
            middle = n / 2;
        }
        else
        {
            middle = n / 2 - 1;
        }

        var line = new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n);
        Console.WriteLine(line);

        for (int row = 0; row < n - 2; row++)
        {
            line = "*" + new string('/', 2 * n - 2) + "*";

            if (row == middle - 1)
            {
                line = line + new string('|', n);
            }
            else
            {
                line = line + new string(' ', n);
            }        
                
            line = line + "*" + new string('/', 2 * n - 2) + "*";
            Console.WriteLine(line);
        }

        line = new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n);
        Console.WriteLine(line);
    }
}
