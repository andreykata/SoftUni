using System;
class SumNumbers
{
    static void Main(string[] args)
    {
        var numbers = int.Parse(Console.ReadLine());
        var sum = 0;

        for (int i = 0; i < numbers; i++)
        {
            var num = int.Parse(Console.ReadLine());
            sum += num;
            // sum = sum + num;
        }

        Console.WriteLine(sum);
    }
}