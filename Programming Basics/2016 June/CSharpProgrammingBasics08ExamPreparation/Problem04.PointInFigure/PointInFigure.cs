using System;
class PointInFigure
{
    static void Main(string[] args)
    {
        var x = int.Parse(Console.ReadLine());
        var y = int.Parse(Console.ReadLine());

        bool checkFirstRectangle = (x >= 2 && x <= 12) && (y <= 1 && y >= -3);
        bool checkSecondRectangle = (x >= 4 && x <= 10) && (y <= -3 && y >= -5);
        bool checkThirdRectangle = (x >= 4 && x <= 10) && (y <= 3 && y >= 1);

        if (checkFirstRectangle || checkSecondRectangle || checkThirdRectangle)
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }
    }
}