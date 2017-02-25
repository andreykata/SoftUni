using System;
class SumDigits
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0;

        while (n > 9)
        {
            var lastDigit = n % 10;
            sum += lastDigit; // sum = sum + lastDigit;
            n /= 10; // n = n / 10;
        }

        Console.WriteLine(sum);
        //Console.WriteLine(n);
    }
}
