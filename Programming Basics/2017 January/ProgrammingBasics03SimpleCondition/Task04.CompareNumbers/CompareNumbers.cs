using System;
class CompareNumbers
{
    static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("Greater number: {0}", a);              
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("Greater number: {0}", b);
        }
        else
        {
            Console.WriteLine("Greater number: {0}", c);
        }

        //Console.WriteLine(Math.Max(a, Math.Max(b, c)));
    }
}
