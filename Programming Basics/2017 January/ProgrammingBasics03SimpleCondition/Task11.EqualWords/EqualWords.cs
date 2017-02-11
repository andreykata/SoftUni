using System;
class EqualWords
{
    static void Main(string[] args)
    {
        var firstWord = Console.ReadLine().ToUpper();
        var secondWord = Console.ReadLine().ToUpper();

        firstWord.ToLower();
        secondWord.ToLower();       
        
        if (firstWord.Equals(secondWord))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

        Console.WriteLine(firstWord);
        // Console.WriteLine(firstWord.Length);    
    }
}
