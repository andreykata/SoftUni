using System;
class DayOfWeek
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        var num = 0;
        switch (number)
        {
            case 1:
                var b = 4;
                Console.WriteLine("Monday");
                break;
            case 2:
                num = 5;
                Console.WriteLine("Thusday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Error!");
                break;
        }
        Console.WriteLine(b);
    }
}
