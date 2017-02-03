using System;
class LeftRightSum
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var leftSum = 0;
        var rightSum = 0;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());
            leftSum = leftSum + number;
        }

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());
            rightSum = rightSum + number;
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
        }
    }
}