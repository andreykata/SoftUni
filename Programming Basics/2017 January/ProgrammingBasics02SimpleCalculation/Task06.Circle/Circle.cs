using System;
class Circle
{
    static void Main(string[] args)
    {
        var r = double.Parse(Console.ReadLine());
        var perimeter = 2 * r * Math.PI;
        var area = Math.PI * Math.Pow(r, 2);

        Console.WriteLine(perimeter);
        Console.WriteLine(area);
    }
}