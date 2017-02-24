using System;
class Stop
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        int rows = 2 * n + 2;
        int cols = (4 * n) + 3;

        // Draw first half
        for (int row = 0; row < n + 1; row++)
        {
            int dotsLenght = n + 1 - row;
            int lowDashLenght = cols - (2 * dotsLenght);
            var dots = new string('.', dotsLenght);            

            if (row == 0)
            {
                var dashes = new string('_', lowDashLenght);
                var line = dots + dashes + dots;
                Console.Write("{0} {1}", line, line.Length);
            }
            else
            {
                var dashes = new string('_', lowDashLenght - 4);
                var line = dots + "//" + dashes + "\\\\" + dots;
                Console.Write("{0} {1}", line, line.Length);
            }

            Console.WriteLine();
        }

        // Draw stop
        var middleLine = "//" + new string('_', cols / 2 - 4) + "STOP!"
            + new string('_', cols / 2 - 4) + "\\\\";
        Console.WriteLine("{0} {1}", middleLine, middleLine.Length);

        // Draw second half
        for (int row = 0; row < n; row++)
        {
            int dotsLenght = row;
            int lowDashLenght = cols - (2 * dotsLenght) - 4;
            var dots = new string('.', dotsLenght);
            var dashes = new string('_', lowDashLenght);
            var line = dots + "\\\\" + dashes + "//" + dots;
            Console.WriteLine("{0} {1}", line, line.Length);
        }

    }
}
