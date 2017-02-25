using System;
class Foreach
{
    static void Main(string[] args)
    {
        string str = "Hello I'm string";

        foreach (char ch in str)
        {
            Console.WriteLine("{0}->{1}", ch, (int)ch);
        }

    }
}
