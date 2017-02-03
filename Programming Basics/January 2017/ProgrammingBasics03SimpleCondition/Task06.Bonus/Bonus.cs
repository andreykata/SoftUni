using System;
class Bonus
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        var bonus = 0.0;
        var result = 0.0;

        if (number <= 100)
        {
            bonus = 5;
        }
        else if (number > 100 && number <= 1000)
        {
            bonus = number * 0.2;
        }
        else if (number > 1000)
        {
            bonus = number * 0.1;
        }

        if (number % 2 == 0)
        {
            bonus = bonus + 1;
        }
        if (number % 10 == 5)
        {
            bonus = bonus + 2;
        }

        result = number + bonus;

        Console.WriteLine(bonus);
        Console.WriteLine(result);
    }
}
