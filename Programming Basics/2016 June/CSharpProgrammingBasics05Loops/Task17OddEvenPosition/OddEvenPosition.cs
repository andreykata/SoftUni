using System;
class OddEvenPosition
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var oddSum = 0.0;
        var oddMin = double.MaxValue;
        var oddMax = double.MinValue;
        var evenSum = 0.0;
        var evenMin = double.MaxValue;
        var evenMax = double.MinValue;

        for (int i = 1; i <= n; i++)
        {
            var number = double.Parse(Console.ReadLine());

            if (i % 2 != 0)
            {
                oddSum = oddSum + number;

                if (number < oddMin)
                {
                    oddMin = number;
                }

                if (number > oddMax)
                {
                    oddMax = number;
                }
            }
            else
            {
                evenSum = evenSum + number;

                if (number < evenMin)
                {
                    evenMin = number;
                }

                if (number > evenMax)
                {
                    evenMax = number;
                }
            }
        }

        Console.WriteLine($"OddSum = {oddSum}");
        Console.WriteLine("OddMin = {0}", oddMin == double.MaxValue ? "No" : oddMin.ToString());
        Console.WriteLine("OddMax = {0}", oddMax == double.MinValue ? "No" : oddMax.ToString());

        Console.WriteLine($"EvenSum = {evenSum}");
        Console.WriteLine("EvenMin = {0}", evenMin == double.MaxValue ? "No" : evenMin.ToString());
        Console.WriteLine("EvenMax = {0}", evenMax == double.MinValue ? "No" : evenMax.ToString());

    }
}
