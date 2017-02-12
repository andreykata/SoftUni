using System;
class LeftRightSum
{
    static void Main(string[] args)
    {
        var numbers = int.Parse(Console.ReadLine());
        var leftSum = 0;
        var rightSum = 0;

        //for (int i = 0; i < numbers; i++)
        //{
        //    var num = int.Parse(Console.ReadLine());
        //    leftSum += num;
        //}

        //for (int i = 0; i < numbers; i++)
        //{
        //    var num = int.Parse(Console.ReadLine());
        //    rightSum += num;
        //}

        for (int i = 0; i < 2 * numbers; i++)
        {
            var num = int.Parse(Console.ReadLine());

            if (i < numbers)
            {
                leftSum += num;
            }
            else
            {
                rightSum += num;
            }
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine("Yes, sum = {0}", leftSum);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
        }
    }
}