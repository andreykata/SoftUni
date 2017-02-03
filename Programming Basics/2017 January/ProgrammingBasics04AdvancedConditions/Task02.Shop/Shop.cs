using System;
class Shop
{
    static void Main(string[] args)
    {
        var product = Console.ReadLine();
        var town = Console.ReadLine();
        var quantity = int.Parse(Console.ReadLine());
        var result = 0.0;

        if (product == "coffee")
        {
            if (town == "Sofia")
            {
                result = quantity * 0.5;
            }
            else if (town == "Plovdiv")
            {
                result = quantity * 0.4;
            }
            else if (town == "Varna")
            {
                result = quantity * 0.45;
            }
        }

        else if (product == "water")
        {
            if (town == "Sofia")
            {
                result = quantity * 0.8;
            }
            else if (town == "Plovdiv")
            {
                result = quantity * 0.7;
            }
            else if (town == "Varna")
            {
                result = quantity * 0.7;
            }
        }

        else if (product == "beer")
        {
            if (town == "Sofia")
            {
                result = quantity * 1.2;
            }
            else if (town == "Plovdiv")
            {
                result = quantity * 1.15;
            }
            else if (town == "Varna")
            {
                result = quantity * 1.1;
            }
        }

        else if (product == "sweets")
        {
            if (town == "Sofia")
            {
                result = quantity * 1.45;
            }
            else if (town == "Plovdiv")
            {
                result = quantity * 1.3;
            }
            else if (town == "Varna")
            {
                result = quantity * 1.35;
            }
        }
        else if (product == "peanuts")
        {
            if (town == "Sofia")
            {
                result = quantity * 1.6;
            }
            else if (town == "Plovdiv")
            {
                result = quantity * 1.5;
            }
            else if (town == "Varna")
            {
                result = quantity * 1.55;
            }
        }

        Console.WriteLine("00{0}", result);
    }
}
