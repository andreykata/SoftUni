using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var number = double.Parse(Console.ReadLine());
        var inputMetric = Console.ReadLine();
        var outputMetric = Console.ReadLine();

        Dictionary<string, double> dict = new Dictionary<string, double>()
        {
            { "m", 1 },
            { "mm", 1000},
            { "cm", 100},
            { "mi", 0.000621371192 },
            { "in", 39.3700787 },
            { "km", 0.001 },
            { "ft", 3.2808399 },
            { "yd", 1.0936133 }
        };
       
        var result = number / dict[inputMetric] * dict[outputMetric];

        Console.WriteLine(result + " " + outputMetric);
    }
}
