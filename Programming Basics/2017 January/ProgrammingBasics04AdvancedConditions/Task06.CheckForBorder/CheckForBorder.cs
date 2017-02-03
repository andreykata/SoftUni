using System;
class CheckForBorder
{
    static void Main(string[] args)
    {
        var x1 = int.Parse(Console.ReadLine());
        var y1 = int.Parse(Console.ReadLine());
        var x2 = int.Parse(Console.ReadLine());
        var y2 = int.Parse(Console.ReadLine());
        var x = int.Parse(Console.ReadLine());
        var y = int.Parse(Console.ReadLine());

        var inRectangle = x > x1 && x < x2 && y > y1 && y < y2;
        var onBorderY = (y == y1 || y == y2) && x > x1 && x < x2;
        var onBorderX = (x == x1 || x == x2) && y > y1 && y < y2;

        if (inRectangle)
        {
            Console.WriteLine("Inside");
        }
        else if (onBorderY || onBorderX)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Outside");
        }

    }
}