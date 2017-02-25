using System;
class Factorial
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var result = 1;

        do
        {
            result *= n;
            n--;
        } while (n > 1);

        Console.WriteLine(result);

        //var secondResult = 1;
        //while (n > 1)
        //{
        //    secondResult *= n;
        //    n--;
        //}
        //Console.WriteLine(secondResult);
    }
}
