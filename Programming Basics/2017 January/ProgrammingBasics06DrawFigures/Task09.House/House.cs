using System;
class House
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        int roofRows = 0;
        int x = n / 2 - 1;
        int y = n / 2;

        if (n % 2 == 0)
        {
            roofRows = n / 2;
        }
        else
        {
            roofRows = n / 2 + 1;
            x = y;
        }

        // Draw roof house
        for (int row = 0; row < roofRows; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col >= x && col <= y)
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

        // Draw body house
        for (int row = 0; row < n / 2; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == 0 || col == n - 1)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();
        }
    }
}
