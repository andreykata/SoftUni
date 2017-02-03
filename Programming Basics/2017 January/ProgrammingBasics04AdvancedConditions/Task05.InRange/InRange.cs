using System;
class InRange
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        bool inRange = (number >= 100 && number <= 200) || number == 0;
        
        if (!inRange)
        {
            Console.WriteLine("invalid");
        }
    }
}
