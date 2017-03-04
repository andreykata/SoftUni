using System;
class LettersCombinations
{
    static void Main(string[] args)
    {
        var startLetter = Console.ReadLine();
        var endLetter = Console.ReadLine();
        var dismissLetter = Console.ReadLine();

        char start = startLetter[0]; // Char.Parse(startLetter);
        char end = endLetter[0];
        char dismiss = dismissLetter[0];

        int count = 0;
        
        for (char i1 = start; i1 <= end; i1++)
        {
            for (char i2 = start; i2 <= end; i2++)
            {
                for (char i3 = start; i3 <= end; i3++)
                {
                    if (i1 != dismiss && i2 != dismiss && i3 != dismiss)
                    {
                        Console.Write("{0}{1}{2} ", i1, i2, i3);
                        count++;
                    }
                }
            }
        }

        Console.WriteLine(count);
    }
}
