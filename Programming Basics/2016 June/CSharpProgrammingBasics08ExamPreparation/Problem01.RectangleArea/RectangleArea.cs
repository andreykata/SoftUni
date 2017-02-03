using System;
class RectangleArea
{
    static void Main(string[] args)
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        var x3 = double.Parse(Console.ReadLine());
        var y3 = double.Parse(Console.ReadLine());

        var a = Math.Abs(x2 - x3);
        var h = Math.Abs(y1 - y2);

        var s = (a * h) / 2;

        Console.WriteLine(s);
    }
}