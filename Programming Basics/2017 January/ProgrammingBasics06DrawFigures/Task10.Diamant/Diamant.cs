using System;
class Diamant
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var dimantRows = n - 1;
        var x = n / 2 - 1;
        var y = n / 2;

        if (n % 2 == 1)
        {
            dimantRows = n;
            x = y;
        }

        // Draw first half
        for (int row = 0; row < dimantRows / 2 + 1; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == x || col == y)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }
            x--;
            y++;
            Console.WriteLine();
        }


        // Draw second half
        x = 1;
        y = n - 2;
        for (int row = 0; row < dimantRows / 2; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == x || col == y)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }
            x++;
            y--;
            Console.WriteLine();
        }
    }
}