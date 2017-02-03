using System;
class EvenOddSum
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var evenSum = 0;
        var oddSum = 0;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenSum = evenSum + number;
            }
            else
            {
                oddSum = oddSum + number;
            }
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine($"Yes, sum = {evenSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {Math.Abs(evenSum - oddSum)}");
        }
    }
}
