using System;
class ShapesArea
{
    static void Main(string[] args)
    {
        var figure = Console.ReadLine();
        var area = 0.0;

        if (figure == "square")
        {
            var side = double.Parse(Console.ReadLine());
            area = side * side;
        }
        else if (figure == "rectangle")
        {
            var firstSide = double.Parse(Console.ReadLine());
            var secondSide = double.Parse(Console.ReadLine());
            area = firstSide * secondSide;
        }
        else if (figure == "circle")
        {
            var radius = double.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;
        }
        else if (figure == "triangle")
        {
            var a = double.Parse(Console.ReadLine());
            var hA = double.Parse(Console.ReadLine());
            area = (a * hA) / 2.0;
        }

        Console.WriteLine(Math.Round(area, 3));
    }
}
