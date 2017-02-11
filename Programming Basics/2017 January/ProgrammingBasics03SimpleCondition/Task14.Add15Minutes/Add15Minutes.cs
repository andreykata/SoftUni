using System;
class Add15Minutes
{
    static void Main(string[] args)
    {
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());

        minutes += 15;

        if (minutes >= 60)
        {
            hours++;
            minutes %= 60;
        }

        if (hours > 23)
        {
            hours = 0;
        }

        Console.WriteLine("{0}:{1}", hours, minutes.ToString().PadLeft(2, '0'));
    }
}
