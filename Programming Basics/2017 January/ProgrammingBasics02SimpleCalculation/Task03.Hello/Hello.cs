using System;
class Hello
{
    static void Main(string[] args)
    {
        var name = Console.ReadLine();
        Console.Write("Hello ");
        Console.Write(name);
        Console.WriteLine("!");

        Console.WriteLine("Hello " + name + "!");

        Console.WriteLine("Hello {0}!", name);

        // Only 2015
        int number = 5;
        Console.WriteLine($"Hello {number}!");
    }
}