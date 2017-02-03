using System;
class IncesToCm
{
    static void Main(string[] args)
    {
        Console.Write("Inches = ");
        var inches = float.Parse(Console.ReadLine());
        var centemeters = inches * 2.54;
        Console.WriteLine("Centemeters = {0}", centemeters);
       
    }
}
