using System;

class Program
{
    static void Main(string[] args)
    {
        var str = "hello # PMG";

        foreach (var letter in str)
        {
            Console.WriteLine(letter);
        }

        for (int i = 0; i < str.Length; i++)
        {
            Console.WriteLine(str[i]);
        }
    }
}
