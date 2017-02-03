using System;
class SumSeconds
{
    static void Main(string[] args)
    {
        var one = int.Parse(Console.ReadLine());
        var two = int.Parse(Console.ReadLine());
        var three = int.Parse(Console.ReadLine());

        var sum = one + two + three;
        var minutes = sum / 60;
        var seconds = sum % 60;

        if (seconds < 10)
        {
            Console.WriteLine("{0}:0{1}", minutes, seconds);
        }
        else
        {
            Console.WriteLine("{0}:{1}", minutes, seconds);
        }
        
        //Console.WriteLine($"{minutes}:{seconds}");
    }
}
