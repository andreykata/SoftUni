using System;

class FullName
{
    static void Main(string[] args)
    {
        var firstName = Console.ReadLine();
        var secondName = Console.ReadLine();
        var age = int.Parse(Console.ReadLine()) + 10;
        var town = Console.ReadLine();

        Console.WriteLine(
            $"You are {firstName} {secondName}, a {age}-years old person from {town}.");
    }
}