using System;
class FuitShop
{
    static void Main(string[] args)
    {
        var fruit = Console.ReadLine();
        var dayOfWeek = Console.ReadLine();
        var quantity = int.Parse(Console.ReadLine());
        var price = 0.0;

        if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
        {
            if (fruit == "banana")
            {
                price = 2.7;
            }
            else if (fruit == "apple")
            {
                price = 1.25;
            }
            else if (fruit == "orange")
            {
                price = 0.9;
            }
            else if (fruit == "grapefruit")
            {
                price = 1.6;
            }
            else if (fruit == "kiwi")
            {
                price = 3;
            }
            else if (fruit == "pineapple")
            {
                price = 5.6;
            }
            else if (fruit == "grapes")
            {
                price = 4.2;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (dayOfWeek == "Monday")
        {
            if (fruit == "banana")
            {
                price = 2.5;
            }
            else if (fruit == "apple")
            {
                price = 1.20;
            }
            else if (fruit == "orange")
            {
                price = 0.85;
            }
            else if (fruit == "grapefruit")
            {
                price = 1.45;
            }
            else if (fruit == "kiwi")
            {
                price = 2.7;
            }
            else if (fruit == "pineapple")
            {
                price = 5.5;
            }
            else if (fruit == "grapes")
            {
                price = 3.85;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }

        Console.WriteLine("{0:0.00}", quantity * price);
    }
}