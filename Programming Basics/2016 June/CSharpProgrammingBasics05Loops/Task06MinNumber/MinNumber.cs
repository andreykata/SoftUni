using System;
class MinNumber
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var minNumber = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());

            if (number < minNumber)
            {
                minNumber = number;
            }
        }

        Console.WriteLine(minNumber);
    }
}