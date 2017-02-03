using System;

class Time
{
    static void Main(string[] args)
    {
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());

        minutes += 15;

        if (minutes > 59)
        {
            hours++;
            minutes = minutes % 60;
        }
        if (hours > 23)
        {
            hours = 0;            
        }
       
        Console.WriteLine("{0}:{1}", hours, minutes.ToString().PadLeft(2, '0'));
    }
}