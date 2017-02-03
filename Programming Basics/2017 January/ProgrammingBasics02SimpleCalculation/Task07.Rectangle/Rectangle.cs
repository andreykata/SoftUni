using System;
class Rectangle
{
    static void Main(string[] args)
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        var widht = Math.Abs(x1 - x2);
        var height = Math.Abs(y1 - y2);

        var perimeter = (2 * widht) + (2 * height);
        var area = widht * height;

        Console.WriteLine("{0}", area);
        Console.WriteLine(perimeter);        
    }
}