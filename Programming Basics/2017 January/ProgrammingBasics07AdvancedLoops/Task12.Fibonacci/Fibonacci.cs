﻿using System;
class Fibonacci
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var f0 = 1;
        var f1 = 1;

        for (int i = 0; i < n - 1; i++)
        {
            var nextF = f0 + f1;
            f0 = f1;
            f1 = nextF;
        }

        Console.WriteLine(f1);
    }
}