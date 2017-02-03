using System;
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n - 1; col++)
            {
                Console.Write("* ");
            }
            Console.Write("*");

            Console.WriteLine();
        }
    }
}