using System;
class Demo
{
    static void Main(string[] args)
    {
        var numberString = Console.ReadLine();
        var number = int.Parse(numberString);

        var numberLenght = numberString.Length;
        int firstDigit = number / (int)(Math.Pow(10, numberLenght - 1));

        Console.WriteLine(firstDigit);

        while (true)
        {
            Console.WriteLine("Infinity!");
            break;
        }

        for (;;)
        {
            Console.WriteLine("i'M FOR");
        }        
    }
}