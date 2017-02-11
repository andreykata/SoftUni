using System;
class PointInFigure
{
    static void Main(string[] args)
    {
        var h = int.Parse(Console.ReadLine());
        var x = int.Parse(Console.ReadLine());
        var y = int.Parse(Console.ReadLine());

        var firstFigure = x > 0 && x < (3 * h) && y > 0 && y < h;
        var secondFigure = x > h && x < (2 * h) && y > h && y < (4 * h);

        if (firstFigure || secondFigure || (x > h && x < (2 * h) && y == h))
        {
            Console.WriteLine("inside");
        }
        else if ((x < 0 || x > (3 * h) || y < 0 || y > h) &&
            (x < h || x > (2 * h) || y < h || y > (4 * h)))
        {
            Console.WriteLine("outside");
        }
        else
        {
            Console.WriteLine("border");
        }
    
    }
}
