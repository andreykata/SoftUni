using System;
class Sequence2kPlus1
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var num = 1;
        while (num <= n)
        {
            Console.WriteLine(num);
            num = num * 2 + 1;
        }
    }
}
