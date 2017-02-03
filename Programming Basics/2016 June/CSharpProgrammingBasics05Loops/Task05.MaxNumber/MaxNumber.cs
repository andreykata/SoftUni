using System;
class MaxNumber
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var maxNumber = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());

            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine(maxNumber);
    }
}