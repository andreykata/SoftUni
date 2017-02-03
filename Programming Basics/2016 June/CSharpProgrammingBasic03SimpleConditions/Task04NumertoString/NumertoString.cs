using System;

class NumertoString
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        if (number == 1)
        {
            Console.WriteLine("One");
        }
        else if (number == 2)
        {
            Console.WriteLine("Two");
        }
        else if (number == 3)
        {
            Console.WriteLine("Three");
        }
        else if (number == 4)
        {
            Console.WriteLine("Four");
        }
        else if (number == 10)
        {
            Console.WriteLine("Ten");
        }
        else
        {
            Console.WriteLine("Too big number");
        }
    }
}
