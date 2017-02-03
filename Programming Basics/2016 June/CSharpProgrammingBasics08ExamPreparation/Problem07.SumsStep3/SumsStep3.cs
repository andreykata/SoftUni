using System;
class SumsStep3
{
    static void Main(string[] args)
    {
        var sum1 = 0;
        var sum2 = 0;
        var sum3 = 0;

        var n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            var number = int.Parse(Console.ReadLine());

            if (i % 3 == 1)
            {
                sum1 = sum1 + number;
            }
            else if (i % 3 == 2)
            {
                sum2 += number;
            }
            else if (i % 3 == 0)
            {
                sum3 += number;
            }
        }

        Console.WriteLine($"sum1 = {sum1}");
        Console.WriteLine($"sum2 = {sum2}");
        Console.WriteLine($"sum3 = {sum3}");

    }
}
