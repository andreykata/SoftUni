using System;
class Distance
{
    static void Main(string[] args)
    {
        var speed = double.Parse(Console.ReadLine());
        var firstTime = int.Parse(Console.ReadLine());
        var secondTime = int.Parse(Console.ReadLine());
        var thirdTime = int.Parse(Console.ReadLine());

        var result = speed*(firstTime/60.0);
        speed = speed * 1.1;

        result += speed*(secondTime/60.0);
        speed = speed*0.95;
        result += speed*(thirdTime/60.0);

        Console.WriteLine("{0:0.00}", result);
    }
}
