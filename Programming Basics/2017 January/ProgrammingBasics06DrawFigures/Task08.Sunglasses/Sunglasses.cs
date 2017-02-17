using System;
class Sunglasses
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var middleRow = 0;

        if (n % 2 == 1)
        {
            middleRow = n / 2 - 1; 
        }
        else
        {
            middleRow = n / 2 - 2;
        }

        // Draw first line
        var line = new string('*', 2 * n);
        line += new string(' ', n);
        line += new string('*', 2 * n);

        Console.WriteLine(line);

        // Draw middle rows
        for (int row = 0; row < n - 2; row++)
        {
            // Draw left glass
            for (int col = 0; col < 2 * n; col++)
            {
                if (col == 0 || col == (2 * n) - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("/");
                }                
            }

            if (row == middleRow)
            {
                var spaces = new string('|', n);
                Console.Write(spaces);
            }
            else
            {
                var spaces = new string(' ', n);
                Console.Write(spaces);
            }
            

            // Draw right glass
            for (int col = 0; col < 2 * n; col++)
            {
                if (col == 0 || col == (2 * n) - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("/");
                }
            }

            Console.WriteLine();
        }

        // Draw last line
        Console.WriteLine(line);
    }
}
