using System;
class Digits
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var first = n / 100;
        var second = (n / 10) % 10;
        var third = n % 10;

        var rows = first + second;
        var cols = first + third;

        for (int row = 0; row < rows; row++)
        { 
            for (int col = 0; col < cols; col++)
            {
                if (n % 5 == 0)
                {
                    n -= first;
                }
                else if (n % 3 == 0)
                {
                    n -= second;
                }
                else
                {
                    n += third;
                }

                Console.Write($"{n} ");
            }

            Console.WriteLine();
        }
    }
}
