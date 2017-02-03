using System;
class IncreasingElements
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var maxLenght = 1;
        var maxCurrentLenght = 1;

        var firstNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            var secondNumber = int.Parse(Console.ReadLine());
            if (secondNumber > firstNumber)
            {
                maxCurrentLenght++;

                if (maxCurrentLenght > maxLenght)
                {
                    maxLenght = maxCurrentLenght;
                }
            }
            else
            {
                maxCurrentLenght = 1;
            }

            firstNumber = secondNumber;
        }

        Console.WriteLine(maxLenght);
    }
}