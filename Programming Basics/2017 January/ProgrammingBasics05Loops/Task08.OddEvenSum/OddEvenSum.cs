using System;
class OddEvenSum
{
    static void Main(string[] args)
    {
        var numbers = int.Parse(Console.ReadLine());
        var evenSum = 0;
        var oddSum = 0;

        for (int i = 0; i < numbers; i++)
        {
            var num = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenSum += num;
            }
            else
            {
                oddSum += num;
            }
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes, sum = {0}", evenSum);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(evenSum - oddSum));
        }
    }
}
