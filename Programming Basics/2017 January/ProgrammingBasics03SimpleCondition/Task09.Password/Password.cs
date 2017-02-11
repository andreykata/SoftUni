using System;
class Password
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        if (input == "s3cr3t!P@ssw0rd")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}
