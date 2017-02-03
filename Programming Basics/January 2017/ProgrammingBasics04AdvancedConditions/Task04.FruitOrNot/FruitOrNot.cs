using System;
class FruitOrNot
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        if (input == "banana" || input == "apple" || input == "kiwi")
        {
            Console.WriteLine("fruit");
        }
        else if (input == "tomato" || input == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
