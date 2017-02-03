using System;
class SumDigits
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0;

        while (n > 0)
        {
            var lastDigit = n % 10;
            sum = sum + lastDigit;
            n = n / 10;
        }

        Console.WriteLine("Sum of digits: {0}", sum);
    }
}