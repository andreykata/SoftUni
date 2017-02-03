using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                Console.Write("+ ");
            }
            else if (i == n - 1)
            {
                Console.Write("+");
            }
            else
            {
                Console.Write("- ");
            }
        }
        Console.WriteLine();

        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == 0)
                {
                    Console.Write("| ");
                }
                else if (col == n - 1)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write("- ");
                }
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            {
                Console.Write("+ ");
            }
            else if (i == n - 1)
            {
                Console.Write("+");
            }
            else
            {
                Console.Write("- ");
            }
        }
        Console.WriteLine();
    }
}