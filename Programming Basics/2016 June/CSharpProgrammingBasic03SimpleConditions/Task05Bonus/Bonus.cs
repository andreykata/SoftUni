using System;

class Bonus
{
    static void Main(string[] args)
    {
        var number = double.Parse(Console.ReadLine());

        if (number < 10)
        {
            Console.WriteLine("< 10");
        }

        else if (number < 100)
        {
            Console.WriteLine("< 100");
        }

        else if (number < 1000)
        {
            Console.WriteLine("< 1000");
        }
        
    }
}