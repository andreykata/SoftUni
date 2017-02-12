using System;
using System.Collections.Generic;
using System.Linq;

class HalfSumElement
{
    static void Main(string[] args)
    {
        var numbers = int.Parse(Console.ReadLine());
        int[] arr = new int[numbers];
        bool hasAnswer = false;

        for (int i = 0; i < numbers; i++)
        {
            var num = int.Parse(Console.ReadLine());
            arr[i] = num;
        }

        var sum = arr.Sum();

        for (int i = 0; i < numbers; i++)
        {
            var number = arr[i];
            var currentSum = sum - number;

            if (number == currentSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", currentSum);
                hasAnswer = true;
            }            
        }

        if (hasAnswer == false)
        {
            var maxNumber = arr.Max();
            var currentSum = arr.Sum() - maxNumber;
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", Math.Abs(maxNumber - currentSum));
        }
    }
}
