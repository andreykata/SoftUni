using System;
using System.Threading;
class Point
{
    static void Main(string[] args)
    {
        var first = int.Parse(Console.ReadLine());
        var second = int.Parse(Console.ReadLine());
        var point = int.Parse(Console.ReadLine());

        if (first > second)
        {
            var temp = first;
            first = second;
            second = temp;
        }

        var minDistance = Math.Min(Math.Abs(first - point), Math.Abs(second - point));

        if (point >= first && point <= second)
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }

        Console.WriteLine(minDistance);
    }
}
