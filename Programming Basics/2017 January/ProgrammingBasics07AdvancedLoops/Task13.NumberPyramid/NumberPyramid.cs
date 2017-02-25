using System;
class NumberPyramid
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var number = 1;

        for (int row = 0; row < n; row++)
        {
            if (number > n)
            {
                break;
            }

            for (int col = 0; col <= row; col++)
            {
                if (number > n)
                {
                    break;
                }
                Console.Write("{0} ", number);
                number++; // number += 1; number = number + 1;
            }
            Console.WriteLine();
        }
    }
}
