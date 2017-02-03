using System;
class Bricks
{
    static void Main(string[] args)
    {
        var totalBricks = int.Parse(Console.ReadLine());
        var workers = int.Parse(Console.ReadLine());
        var capacity = int.Parse(Console.ReadLine());

        var movedBricks = workers * capacity;
        var result = totalBricks / movedBricks;
        var ostatuk = totalBricks % movedBricks;

        if (ostatuk != 0)
        {
            result = result + 1;
        }

        Console.WriteLine(result);
    }
}
