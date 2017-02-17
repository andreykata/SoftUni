using System;
class Square
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        for (int row = 0; row < number; row++)
        {
            for (int col = 0; col < number - 1; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("*");
        }

        //string[] arr = new string[number];
        //for (int i = 0; i < number; i++)
        //{
        //    arr[i] = "*";
        //}

        //for (int i = 0; i < number; i++)
        //{
        //    Console.WriteLine(String.Join(" ", arr));
        //}
    }
}
