using System;
class Increasing4Numbers
{
    static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());

        if (b - a < 3)
        {
            Console.WriteLine("no");
        }
        else
        {
            for (int i1 = a; i1 <= b; i1++)
            {
                for (int i2 = i1 + 1; i2 <= b; i2++)
                {
                    for (int i3 = i2 + 1; i3 <= b; i3++)
                    {
                        for (int i4 = i3 + 1; i4 <= b; i4++)
                        {
                            Console.WriteLine($"{i1} {i2} {i3} {i4}");
                        }
                    }
                }
            }
        }
        
    }
}
