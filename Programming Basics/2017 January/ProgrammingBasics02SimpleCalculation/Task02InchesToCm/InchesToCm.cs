using System;
class InchesToCm
{
    static void Main(string[] args)
    {
        var inches = double.Parse(Console.ReadLine());
        var sm = inches * 2.54;
        Console.Write("Centimetres = ");
        Console.WriteLine(sm);

        Console.WriteLine(Math.Floor(sm));
    }
}