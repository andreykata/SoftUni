using System;
class EvenNumber
{
    static void Main(string[] args)
    {
        var n = 0;

        while (true)
        {
            try
            {
                Console.Write("Enter even number: ");
                n = int.Parse(Console.ReadLine());

                if (n % 2 != 0)
                {
                    Console.WriteLine("The number is not even.");
                }
                else
                {
                    break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number.");
            }
            
        }

        Console.WriteLine("Even number entered: {0}", n);
    }
}