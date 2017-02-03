using System;
class NumberPyramid
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var number = 1;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < row + 1; col++)
            {
                if (number > n)
                {
                    break;
                }

                Console.Write(number + " ");
                number++;
            }

            Console.WriteLine();

            if (number > n)
            {
                break;
            }
        }
    }
}