using System;

class SquareArea
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        var num = int.Parse(Console.ReadLine());
        var area = num * num;
        Console.Write("Square = ");
        Console.WriteLine(area);
    }
}