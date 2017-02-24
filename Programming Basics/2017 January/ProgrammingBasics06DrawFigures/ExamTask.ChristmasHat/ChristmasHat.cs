using System;
class ChristmasHat
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        int rows = 2 * n + 5;
        int cols = 4 * n + 1;

        int dotsLenght = (cols - 3) / 2;
        string dots = new string('.', dotsLenght);
        string line = dots + "/|\\" + dots;

        // Draw first line
        Console.WriteLine(line);
        //Console.WriteLine("{0} {1}", line, line.Length);

        // Draw second line
        line = dots + "\\|/" + dots;
        Console.WriteLine(line);
        //Console.WriteLine("{0} {1}", line, line.Length);

        // Draw middle
        for (int row = 0; row < rows - 5; row++)
        {
            dotsLenght = (cols - 3) / 2 - row;
            dots = new string('.', dotsLenght);
            string middle = "*" + new string('-', row) + "*"
                + new string('-', row) + "*";
            line = dots + middle + dots;

            Console.WriteLine(line);
            //Console.WriteLine("{0} {1}", line, line.Length);
        }

        Console.WriteLine(new string('*', cols));

        for (int col = 0; col < cols; col++)
        {
            if (col % 2 == 0)
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
