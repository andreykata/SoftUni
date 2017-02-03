using System;
class Factorial
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var result = 1;

        //do
        //{
        //    result = result * n;
        //    n--;
        //} while (n > 1);

        // 5 * 4 * 3 * 2 * 1
        //while (n > 1)      
        //{
        //    result = result * n;
        //    n--;
        //}

        // 1 * 2 * 3 * 4 * 5
        for (int i = 1; i <= n; i++)
        {
            result = result * i;
        }

        Console.WriteLine(result);
    }
}
