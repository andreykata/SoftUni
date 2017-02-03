using System;
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            var x = n / 2 - 1;
            var y = n / 2;

            for (int row = 0; row < n / 2; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col < x)
                    {
                        Console.Write("-");
                    }
                    else if (col > y)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                x = x - 1;
                y = y + 1;
                Console.WriteLine();                
            }
        }
        else
        {
            var x = n / 2;
            var y = n / 2;

            for (int row = 0; row < n / 2 + 1; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col < x)
                    {
                        Console.Write("-");
                    }
                    else if (col > y)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                x = x - 1;
                y = y + 1;
                Console.WriteLine();
            }
        }

        for (int row = 0; row < n / 2; row++)
        {
            var line = "|" + new string('*', n - 2) + "|";
            Console.WriteLine(line);
        }
    }
}
