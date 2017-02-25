using System;
class EvenNumber
{
    static void Main(string[] args)
    {
        int n = 0;
        while (true)
        {
            try
            {
                Console.WriteLine("Enter even number: ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The number is not even.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number.");
            }
        }
        Console.WriteLine("The even number is {0}", n);
    }
}
