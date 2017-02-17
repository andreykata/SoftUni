using System;
class RectangleN
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        //for (int i = 0; i < number; i++)
        //{
        //    Console.WriteLine(new string('*', number));
        //}

        for (int row = 0; row < number; row++)
        {
            for (int col = 0; col < number; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
