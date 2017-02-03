using System;

class TriangleOf55Stars
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            var star = new string('*', i + 1);
            Console.WriteLine(star);
        }
    }
}
