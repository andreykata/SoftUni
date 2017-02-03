using System;
class Axe
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            var star = 3 * n;

            for (int col = 0; col < 5 * n; col++)
            {
                if (col == star || col == star + 1 + row)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine();
        }

        var line = new string('*', 3 * n + 1) + new string('-', n - 1) + "*" + new string('-', n - 1);
        for (int row = 0; row < n / 2; row++)
        {
            Console.WriteLine(line);
        }
        
        var left = 3 * n;
        var right = 4 * n;
        for (int row = 0; row < n / 2; row++)
        {            
            for (int col = 0; col < n * 5; col++)
            {
                if (row == n / 2 - 1)
                {
                    if (col >= left && col <= right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                else
                {
                    if (col == left || col == right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }                
            }

            left--;
            right++;
            Console.WriteLine();
        }
    }
}
