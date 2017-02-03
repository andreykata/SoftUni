using System;
class Convertor
{
    static void Main(string[] args)
    {
        var value = int.Parse(Console.ReadLine());
        var inputMetric = Console.ReadLine();
        var outputMetric = Console.ReadLine();
        var result = 0.0;

        // To metrics
        if (inputMetric == "mm")
        {
            result = value / 1000;
        }
        else if (inputMetric == "cm")
        {
            result = value / 100;
        }
        else if (inputMetric == "mi")
        {
            result = value / 0.000621371192;
        }
        else if (inputMetric == "in")
        {
            result = value / 39.3700787;
        }
        else if (inputMetric == "km")
        {
            result = value / 0.001;
        }
        else if (inputMetric == "ft")
        {
            result = value / 3.2808399;
        }
        else if (inputMetric == "yd")
        {
            result = value / 1.0936133;
        }

        //Console.WriteLine(result);

        // From metric to ...
        if (outputMetric == "mm")
        {
            result = result * 1000;
        }
        else if (outputMetric == "cm")
        {
            result = result * 100;
        }
        else if (outputMetric == "mi")
        {
            result = result * 0.000621371192;
        }
        else if (outputMetric == "in")
        {
            result = result * 39.3700787;
        }
        else if (outputMetric == "km")
        {
            result = result * 0.001;
        }
        else if (outputMetric == "ft")
        {
            result = result * 3.2808399;
        }
        else if (outputMetric == "yd")
        {
            result = result * 1.0936133;
        }

        Console.WriteLine(result);

    }
}
