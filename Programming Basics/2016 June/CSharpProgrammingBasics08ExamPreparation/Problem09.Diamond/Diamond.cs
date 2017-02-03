using System;
class Diamond
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            var spaces = new string(' ', n - 1 - row);
            Console.Write(spaces);

            var len = 1 + (2 * row);

            for (int col = 0; col < len; col++)
            {
                if (col % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine();
        }

        for (int row = 0; row < n - 1; row++)
        {
            var spaces = new string(' ', row + 1);
            Console.Write(spaces);

            var len = ((2 * n) - 3) - (2 * row);

            for (int col = 0; col < len; col++)
            {
                if (col % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine();
        }
    }
}
