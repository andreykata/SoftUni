using System;
class Triangle
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        for (int row = 0; row < number; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                Console.Write("$");
            }
            Console.WriteLine();
        }
    }
}
