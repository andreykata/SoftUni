using System;
class ChristmasTree
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n + 1; row++)
        {
            var spaces = new string(' ', n - row);
            Console.Write(spaces);

            //var stars = new string('*', row);
            //Console.Write(stars);

            for (int col = 0; col < row; col++)
            {
                Console.Write("*");
            }

            Console.Write(" | ");

            for (int col = 0; col < row; col++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
