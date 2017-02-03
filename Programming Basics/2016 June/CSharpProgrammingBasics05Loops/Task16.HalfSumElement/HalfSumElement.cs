using System;

class HalfSumElement
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());
            array[i] = number;
        }

        var maxNumber = int.MinValue;
        var sumAllExceptMaxNumber = 0;
        var hasAnswer = false;

        for (int i = 0; i < array.Length; i++)
        {
            int currentNumber = array[i];
            int sum = 0;

            for (int j = 0; j < array.Length; j++)
            {
                if (i != j)
                {
                    sum = sum + array[j];
                }
            }

            if (currentNumber > maxNumber)
            {
                maxNumber = currentNumber;
                sumAllExceptMaxNumber = sum;
            }

            if (currentNumber == sum)
            {
                Console.WriteLine($"Yes, sum = {sum}");
                hasAnswer = true;
            }            
        }

        if (!hasAnswer)
        {
            Console.WriteLine($"No, diff = {Math.Abs(maxNumber - sumAllExceptMaxNumber)}");
        }
    }
}
