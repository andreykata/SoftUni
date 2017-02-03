using System;

class MetricConverter
{
    static void Main(string[] args)
    {
        var number = double.Parse(Console.ReadLine());
        var inputMetric = Console.ReadLine();
        var outputMetric = Console.ReadLine();

        var inputCoef = 1.0;
        var outputCoef = 1.0;

        // Input metrics
        if (inputMetric == "m")
        {
            inputCoef = 1;
        }
        else if (inputMetric == "mm")
        {
            inputCoef = 0.001;
        }
        else if (inputMetric == "cm")
        {
            inputCoef = 0.01;
        }
        else if (inputMetric == "mi")
        {
            inputCoef = 1 / 0.000621371192;
        }
        else if (inputMetric == "in")
        {
            inputCoef = 1 / 39.3700787;
        }
        else if (inputMetric == "km")
        {
            inputCoef = 1000;
        }
        else if (inputMetric == "ft")
        {
            inputCoef = 1 / 3.2808399;
        }
        else if (inputMetric == "yd")
        {
            inputCoef = 1 / 1.0936133;
        }

        // Output metrics
        if (outputMetric == "m")
        {
            outputCoef = 1;
        }
        else if (outputMetric == "mm")
        {
            outputCoef = 1000;
        }
        else if (outputMetric == "cm")
        {
            outputCoef = 100;
        }
        else if (outputMetric == "mi")
        {
            outputCoef = 0.000621371192;
        }
        else if (outputMetric == "in")
        {
            outputCoef = 39.3700787;
        }
        else if (outputMetric == "km")
        {
            outputCoef = 0.001;
        }
        else if (outputMetric == "ft")
        {
            outputCoef = 3.2808399;
        }
        else if (outputMetric == "yd")
        {
            outputCoef = 1.0936133;
        }

        var result = number * inputCoef * outputCoef;
        
        Console.WriteLine(result + " " + outputMetric);
    }
}