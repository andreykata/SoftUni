using System;

class SumSeconds
{
    static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        var sum = a + b + c;

        var minutes = sum / 60;
        var seconds = sum % 60;

        Console.WriteLine("{0}:{1}", minutes, seconds.ToString().PadLeft(2, '0'));

    }
}

