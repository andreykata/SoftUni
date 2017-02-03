using System;
class Hotel
{
    static void Main(string[] args)
    {
        var month = Console.ReadLine();
        var nights = int.Parse(Console.ReadLine());

        var studio = 0D;
        var apartament = 0D;
        var discountStudio = 1D;
        var discountApart = 1D;

        if (month == "May" || month == "October")
        {
            if (nights > 14)
            {
                discountStudio = 0.7;
                discountApart = 0.9;
            }
            else if (nights > 7)
            {
                discountStudio = 0.95;
            }

            studio = 50 * nights * discountStudio;
            apartament = 65 * nights * discountApart;
        }

        else if (month == "June" || month == "September")
        {            
            if (nights > 14)
            {
                discountStudio = 0.8;
                discountApart = 0.9;
            }

            studio = nights * 75.2 * discountStudio;
            apartament = nights * 68.7 * discountApart;
        }

        else if (month == "July" || month == "August")
        {            
            if (nights > 14)
            {
                discountApart = 0.9;
            }

            studio = nights * 76;
            apartament = nights * 77 * discountApart;
        }
    

        Console.WriteLine($"Apartment: {apartament:f2} lv.");
        Console.WriteLine($"Studio: {studio:f2} lv.");
    }
}