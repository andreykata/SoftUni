using System;
class RectangleWithStars
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var rows = n + 2;
        var cols = 2 * n;
        var middleRow = n / 2 + 1;

        if (n % 2 == 0)
        {
            rows = n + 1;
            middleRow = n / 2;
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (row == 0 || row == rows - 1)
                {
                    Console.Write("%");
                }
                else
                {
                    if (row == middleRow)
                    {
                        if (col == 0 || col == cols - 1)
                        {
                            Console.Write("%");
                        }
                        else if (col == n - 1 || col == n)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (col == 0 || col == cols - 1)
                        {
                            Console.Write("%");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}