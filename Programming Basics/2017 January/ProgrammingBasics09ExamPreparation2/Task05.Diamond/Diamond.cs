using System;
class Diamond
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var rows = 3 * n + 2;
        var cols = 5 * n;
        var x = n;
        var y = cols - n - 1;
        var isIncrease = true;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                // Draw first line
                if (row == 0)
                {
                    if (col >= x && col <= y)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                else if (row < n)
                {
                    // Draw first middle
                    if (col == x || col == y)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                else if (row == n)
                {
                    // Draw stars only
                    Console.Write("*");
                    isIncrease = false;
                }
                else if (row > n && row < rows - 1)
                {                    
                    if (col == x || col == y)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                else
                {
                    if (col >= x && col <= y)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            }

            if (isIncrease)
            {
                x--;
                y++;
            }
            else
            {
                x++;
                y--;
            }

            Console.WriteLine();
        }

    }
}
