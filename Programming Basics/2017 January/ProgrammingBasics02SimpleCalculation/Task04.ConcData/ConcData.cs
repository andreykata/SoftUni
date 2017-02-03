using System;
class ConcData
{
    static void Main(string[] args)
    {
        var firstName = Console.ReadLine();
        var lastName = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var town = Console.ReadLine();

        Console.WriteLine("You are {0} {1}, a {2} - years old person from {3}.",
            firstName, lastName, age, town);

        // VS2015 only
        // Console.WriteLine($"You are {firstName} {lastName}, a {age} - years old person from {town}.");
    }
}