using System;
class MaxCombinations
{
    static void Main(string[] args)
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());
        var comabinationsMaxCount = int.Parse(Console.ReadLine());
        var count = 0;

        for (int i1 = firstNumber; i1 <= secondNumber; i1++)
        {
            for (int i2 = firstNumber; i2 <= secondNumber; i2++)
            {
                if (count >= comabinationsMaxCount)
                {
                    i1 = secondNumber + 1;
                    break;
                }
                Console.Write("<{0}-{1}>", i1, i2);
                count++;
            }
        }
    }
}