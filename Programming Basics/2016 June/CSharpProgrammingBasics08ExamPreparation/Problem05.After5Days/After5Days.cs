using System;
class After5Days
{
    static void Main(string[] args)
    {
        var day = int.Parse(Console.ReadLine());
        var month = int.Parse(Console.ReadLine());

        var after5Days = day + 5;

        if (after5Days > 31)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                after5Days = after5Days % 31;
                month++;
            }            
        }
        if (after5Days > 30)
        {
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                after5Days = after5Days % 30;
                month++;
            }
        }
        if (after5Days > 28)
        {
            if (month == 2)
            {
                after5Days = after5Days % 28;
                month = month + 1;
            }            
        }

        if (month > 12)
        {
            month = month % 12;
        }

        Console.WriteLine($"{after5Days}.{month.ToString().PadLeft(2, '0')}");
    }
}