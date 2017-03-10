using System;
class Money
{
    static void Main(string[] args)
    {
        var bits = int.Parse(Console.ReadLine());
        var yoans = double.Parse(Console.ReadLine());
        var comission = double.Parse(Console.ReadLine());

        var bitsToLv = bits * 1168;
        var yoansToDollars = yoans * 0.15;
        var dollarsToLv = yoansToDollars * 1.76;
        var euros = (bitsToLv + dollarsToLv) / 1.95;
        euros = euros - (euros * comission / 100);

        Console.WriteLine(euros);
    }
}