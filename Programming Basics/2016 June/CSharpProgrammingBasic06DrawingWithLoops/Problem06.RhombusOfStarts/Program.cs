﻿using System;
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            var spaces = new string(' ', n - row - 1);
            Console.Write(spaces);

            for (int col = 0; col < row + 1; col++)
            {  
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        for (int row = 0; row < n - 1; row++)
        {
            var spaces = new string(' ', row + 1);
            Console.Write(spaces);

            for (int col = 0; col < n - 1 - row; col++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}
