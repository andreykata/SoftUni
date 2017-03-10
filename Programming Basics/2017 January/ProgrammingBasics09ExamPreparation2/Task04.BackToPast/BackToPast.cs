using System;
class BackToPast
{
    static void Main(string[] args)
    {
        var nasledstvo = double.Parse(Console.ReadLine());
        var year = int.Parse(Console.ReadLine());
        var age = 18;

        for (int i = 1800; i <= year; i++)
        {
            if (i % 2 == 0)
            {
                nasledstvo = nasledstvo - 12000;
            }
            else
            {
                nasledstvo = nasledstvo - (12000 + 50 * age);
            }
            age++;
        }

        if (nasledstvo >= 0)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:0.00} dollars left.", nasledstvo);
        }
        else
        {
            //throw new Exception();
            Console.WriteLine("He will need {0:0.00} dollars to survive.", Math.Abs(nasledstvo));
        }
    }
}
