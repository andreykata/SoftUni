using System;

class Hello
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name = ");
        var name = Console.ReadLine();
        Console.Write("Hello, ");
        Console.Write(name);
        Console.WriteLine("!");
    }
}