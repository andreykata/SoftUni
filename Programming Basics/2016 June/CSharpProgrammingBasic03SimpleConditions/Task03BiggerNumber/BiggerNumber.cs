using System;

class BiggerNumber
{
    static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("The bigger number is {0}", a);
        }
        else if (a == b)
        {
            Console.WriteLine("The numbers are equals");
        }
        else if(b > a) 
        {
            Console.WriteLine("The bigger number is {0}", b);
        }
    }
}
