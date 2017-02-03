using System;
class CheckPrime
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var end = Math.Sqrt(n);
        var isPrime = true;

        if (n < 2)
        {
            isPrime = false;
        }

        for (int i = 2; i <= end; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not prime");
        }
    }
}
