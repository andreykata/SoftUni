﻿using System;
class NumberInRange1to100
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        while (n < 1 || n > 100)
        {
            Console.WriteLine("Invalid number!");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The number is: {n}");

        //while (true)
        //{
        //    if (n >= 1 && n <= 100)
        //    {
        //        Console.WriteLine($"The number is: {n}");
        //        break;
        //    }

        //    Console.WriteLine("Invalid number!");
        //    n = int.Parse(Console.ReadLine());
        //}
    }
}
