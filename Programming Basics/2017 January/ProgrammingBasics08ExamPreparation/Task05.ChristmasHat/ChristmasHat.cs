using System;
class ChristmasHat
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var cols = 4 * n + 1;
        var rows = 2 * n + 5;

        var dotsLenght = cols / 2 - 1;
        string dots = new string('.', dotsLenght);
        Console.WriteLine(dots + "/|\\" + dots);
        Console.WriteLine(dots + "\\|/" + dots);

        var dashLenght = 0;
        for (int row = 0; row < rows - 5; row++)
        {
            dots = new string('.', dotsLenght);
            string dashes = new string('-', dashLenght);
            Console.WriteLine(dots + "*" + dashes + "*" + dashes + "*" + dots);

            dotsLenght--;
            dashLenght++;
        }

        Console.WriteLine(new string('*', cols));

        for (int i = 0; i < cols; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();

        Console.WriteLine(new string('*', cols));

    }
}