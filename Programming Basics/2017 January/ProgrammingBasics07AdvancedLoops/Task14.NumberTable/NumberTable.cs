using System;
class NumberTable
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        bool increase = true;

        for (int row = 0; row < n; row++)
        {
            var number = 1 + row;

            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ", number);

                if (number >= n)
                {
                    increase = false;
                }

                if (increase)
                {
                    number++;
                }
                else
                {
                    number--;
                }
            }
            Console.WriteLine();
            increase = true;
        }
    }
}
