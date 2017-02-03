using System;
class Gender
{
    static void Main(string[] args)
    {
        var age = int.Parse(Console.ReadLine());
        var gender = Console.ReadLine();

        if (gender == "m")
        {
            if (age > 16)
            {
                Console.WriteLine("Mr.");
            }
            else
            {
                Console.WriteLine("Master");
            }
        }
        else
        {
            if (age > 16)
            {
                Console.WriteLine("Ms.");
            }
            else
            {
                Console.WriteLine("Miss");
            }
        }
    }
}
