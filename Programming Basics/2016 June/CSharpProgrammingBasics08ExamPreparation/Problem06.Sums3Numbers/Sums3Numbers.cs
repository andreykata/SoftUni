using System;
class Sums3Numbers
{
    static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        if (a + b == c)
        {            
            Console.WriteLine($"{Math.Min(a, b)} + {Math.Max(a, b)} = {c}");
        }
        else if (a + c == b)
        {
            Console.WriteLine($"{Math.Min(a, c)} + {Math.Max(a, c)} = {b}");
        }
        else if (b + c == a)
        {
            Console.WriteLine($"{Math.Min(b, c)} + {Math.Max(b, c)} = {a}");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
