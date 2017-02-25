using System;
class NumberStep3
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}
