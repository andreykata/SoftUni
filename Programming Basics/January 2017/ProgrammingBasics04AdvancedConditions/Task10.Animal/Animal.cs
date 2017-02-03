using System;
class Animal
{
    static void Main(string[] args)
    {
        var animal = Console.ReadLine();
        var snake = "snake";

        switch (animal)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
            case "crocodile":
            case "snake":
            case "tortoise":
                Console.WriteLine("reptile"); break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}
