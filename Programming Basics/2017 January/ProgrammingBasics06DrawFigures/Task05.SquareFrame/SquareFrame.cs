using System;
class SquareFrame
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        // Draw first row
        for (int col = 0; col < number; col++)
        {
            if (col == 0 || col == number - 1)
            {
                Console.Write("+ ");
            }
            else
            {
                Console.Write("- ");
            }
        }
        Console.WriteLine();

        // Draw middle rows
        for (int row = 0; row < number - 2; row++)
        {
            for (int col = 0; col < number; col++)
            {
                if (col == 0 || col == number - 1)
                {
                    Console.Write("| ");
                }
                else
                {
                    Console.Write("- ");
                }
            }

            Console.WriteLine();
        }

        // Draw last row
        for (int col = 0; col < number; col++)
        {
            if (col == 0 || col == number - 1)
            {
                Console.Write("+ ");
            }
            else
            {
                Console.Write("- ");
            }
        }
        Console.WriteLine();
    }
}
