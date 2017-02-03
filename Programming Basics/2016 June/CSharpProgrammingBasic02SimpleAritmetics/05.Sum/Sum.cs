using System;

class Sum
{
    static void Main(string[] args)
    {
        var r = double.Parse(Console.ReadLine());
        var per = 2 * r * Math.PI;
        var area = Math.PI * Math.Pow(r, 2);

        //Console.WriteLine("{0}", per);
        Console.WriteLine(area);
    }
}