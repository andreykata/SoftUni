using System;
class CheckPrime
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var dev = 2;
        bool isPrime = true;

        while (dev < n)
        {
            if (n % dev == 0)
            {
                Console.WriteLine("Not prime");
                isPrime = false;
                break;
            }
            dev++;
        }

        //for (int i = 2; i < Math.Sqrt(n); i++)
        //{
        //    if (n % i == 0)
        //    {
        //        Console.WriteLine("Not prime");
        //        isPrime = false;
        //        break;
        //    }
        //}

        if (isPrime)
        {
            Console.WriteLine("Prime");
        }
    }
}
