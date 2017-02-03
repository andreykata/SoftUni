using System;
class NumberTable
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                var number = row + col + 1;
                if (number > n)
                {
                    number = 2 * n - number;
                }

                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}