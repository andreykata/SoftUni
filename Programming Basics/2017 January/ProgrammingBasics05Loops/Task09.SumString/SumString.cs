using System;
class SumString
{
    static void Main(string[] args)
    {
        //var input = "hello";
        var input = Console.ReadLine();
        var sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            var letter = input[i];

            switch (letter)
            {
                case 'a': sum += 1;
                    break;
                case 'e': sum += 2;
                    break;
                case 'i': sum += 3;
                    break;
                case 'o': sum += 4;
                    break;
                case 'u': sum += 5;
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine(sum);
    }
}