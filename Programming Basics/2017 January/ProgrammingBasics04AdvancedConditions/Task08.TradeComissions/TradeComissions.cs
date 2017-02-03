using System;
class TradeComissions
{
    static void Main(string[] args)
    {
        var town = Console.ReadLine();
        var value = double.Parse(Console.ReadLine());
        var comission = 0.0;

        if (value >= 0 && value <= 500)
        {
            if (town == "Sofia")
            {
                comission = 0.05;
            }
            else if (town == "Varna")
            {
                comission = 0.045;
            }
            else if (town == "Plovdiv")
            {
                comission = 0.055;
            }
        }
        else if (value > 500 && value <= 1000)
        {

        }

        Console.WriteLine("{0:0.00}", value * comission);
    }
}
