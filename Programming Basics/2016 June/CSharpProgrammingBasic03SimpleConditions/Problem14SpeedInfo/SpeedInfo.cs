using System;

class SpeedInfo
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        if (number <= 10)
        {
            Console.WriteLine("sloow");
        }
        else if (number <= 50)
        {
            Console.WriteLine("average");
        }
        else if (number <= 150)
        {
            Console.WriteLine("fast");
        }
        else if (number <= 1000)
        {
            Console.WriteLine("ultra fast");
        }
        else if (number > 1000)
        {
            Console.WriteLine("extremely fast");
        }
    }
}