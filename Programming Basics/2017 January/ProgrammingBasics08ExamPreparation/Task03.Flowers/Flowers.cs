using System;
class Flowers
{
    static void Main(string[] args)
    {
        var hrizantemiCount = int.Parse(Console.ReadLine());
        var roseCount = int.Parse(Console.ReadLine());
        var laletaCount = int.Parse(Console.ReadLine());
        var seasone = Console.ReadLine().ToLower();
        var day = Console.ReadLine().ToLower();
        var result = 0.0;

        if (seasone == "spring" || seasone == "summer")
        {
            result = (hrizantemiCount * 2) + (roseCount * 4.1) + (laletaCount * 2.5);
        }
        else
        {
            result = (hrizantemiCount * 3.75) + (roseCount * 4.5) + (laletaCount * 4.15);
        }

        if (day == "y")
        {
            result *= 1.15;
            // result = result * 1 + result * 0.15;
        }

        if (laletaCount > 7 && seasone == "spring")
        {
            result *= 0.95;
        }
        if (roseCount >= 10 && seasone == "winter")
        {
            result *= 0.9;
        }
        if (hrizantemiCount + roseCount + laletaCount > 20)
        {
            result *= 0.8;
        }

        result += 2;

        Console.WriteLine("{0:0.00}", result);
    }
}