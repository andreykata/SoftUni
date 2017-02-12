using System;
class MaxNumber
{
    static void Main(string[] args)
    {
        var numbers = int.Parse(Console.ReadLine());
        var maxNumber = int.MinValue;

        for (int i = 0; i < numbers; i++)
        {
            var num = int.Parse(Console.ReadLine());
            
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }

        Console.WriteLine(maxNumber);
    }
}
