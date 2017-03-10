using System;
class Harvest
{
    static void Main(string[] args)
    {
        var area = int.Parse(Console.ReadLine());
        var kgPerSqMeter = double.Parse(Console.ReadLine());
        var needWine = int.Parse(Console.ReadLine());
        var worker = int.Parse(Console.ReadLine());

        var productWine = (area * kgPerSqMeter * 0.4) / 2.5;
        var restWine = productWine - needWine;

        if (restWine >= 0)
        {
            var winePerWorker = restWine / worker;
            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(productWine)} liters.");
            Console.WriteLine($"{Math.Ceiling(restWine)} liters left -> {Math.Ceiling(winePerWorker)} liters per person.");
        }
        else
        {
            restWine *= -1;
            Console.WriteLine($"It will be a tough winter! More {Math.Floor(restWine)} liters wine needed.");
        }
        
    }
}
