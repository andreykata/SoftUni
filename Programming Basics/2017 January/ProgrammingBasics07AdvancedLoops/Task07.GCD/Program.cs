using System;
class Program
{
    static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        int counter = 0;

        while (b != 0)
        {
            var c = b;
            b = a % b;
            a = c;
            counter++;
        }

        Console.WriteLine(a);
        //Console.WriteLine(counter);

        //if (a > b)
        //{
        //    var c = a;
        //    a = b;
        //    b = c;
        //}

        //var d = a;
        //while (d > 0)
        //{
        //    if (a % d == 0 && b % d == 0)
        //    {
        //        Console.WriteLine(d);
        //        break;
        //    }
        //    d--;
        //    counter++;
        //}
        //Console.WriteLine(counter);
    }
}
