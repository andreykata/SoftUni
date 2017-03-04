using System;
class ChangeTails
{
    static void Main(string[] args)
    {
        var amount = double.Parse(Console.ReadLine());
        var lenghtRectangle = double.Parse(Console.ReadLine());
        var widthRectangle = double.Parse(Console.ReadLine());
        var sideTriangle = double.Parse(Console.ReadLine());
        var heightTriangle = double.Parse(Console.ReadLine());
        var tileCost = double.Parse(Console.ReadLine());
        var masterTilePrice = double.Parse(Console.ReadLine());

        var rectangleArea = lenghtRectangle * widthRectangle;
        var triangleArea = sideTriangle * heightTriangle/2;
        var tileCountDouble = rectangleArea / triangleArea;
        var tileCount = Math.Ceiling(tileCountDouble);
        tileCount += 5;

        var totalCost = tileCount * tileCost + masterTilePrice;

        if (amount >= totalCost)
        {
            Console.WriteLine("{0:0.00} lv left.", amount - totalCost);
        }
        else
        {
            Console.WriteLine("You'll need {0:0.00} lv more.", totalCost - amount);
        }
    }
}