using System;
class NumbersNto1
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 1; i--) // i = i - 1; i -= 1
        {
            Console.WriteLine(i);
        }
    }
}