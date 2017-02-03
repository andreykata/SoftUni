using System;
class Pool
{
    static void Main(string[] args)
    {
        var volume = int.Parse(Console.ReadLine());
        var pipe1 = int.Parse(Console.ReadLine());
        var pipe2 = int.Parse(Console.ReadLine());
        var hours = double.Parse(Console.ReadLine());

        var litersInside = (pipe1 + pipe2) * hours;
        var procentFull = (litersInside / volume) * 100;
        var procentPipe1 = ((pipe1 * hours) / litersInside) * 100;
        var procentPipe2 = ((pipe2 * hours) / litersInside) * 100;

        if (litersInside > volume)
        {
            var extraLitters = litersInside - volume;
            Console.WriteLine($"For {hours} hours the pool overflows with {extraLitters} liters.");
        }
        else
        {
            Console.WriteLine($"The pool is {Math.Floor(procentFull)}% full. Pipe 1: {Math.Floor(procentPipe1)}%. Pipe 2: {Math.Floor(procentPipe2)}%.");
        }
        
    }
}