using System;
class FiguresArea
{
    static void Main(string[] args)
    {
        var figure = Console.ReadLine();
        var result = 0.0;

        if (figure == "square")
        {
            var side = double.Parse(Console.ReadLine());

            result = side * side;
        }

        Console.WriteLine("{0:F3}", result);
    }
}
