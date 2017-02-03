using System;
class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            var line = new string('*', 10);
            Console.WriteLine(line);
        }
        
    }
}