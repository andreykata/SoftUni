using System;
class MinValue
{
    static void Main(string[] args)
    {
        var numbers = int.Parse(Console.ReadLine());
        var minNumber = int.MaxValue;

        for (int i = 0; i < numbers; i++)
        {
            var num = int.Parse(Console.ReadLine());

            if (num < minNumber)
            {
                minNumber = num;
            }
        }

        Console.WriteLine(minNumber);
    }
}
