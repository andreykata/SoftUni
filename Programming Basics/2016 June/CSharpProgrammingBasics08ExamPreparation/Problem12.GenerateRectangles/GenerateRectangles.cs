using System;
class GenerateRectangles
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());
        var hasAnswer = false;

        for (int x1 = -n; x1 < n; x1++)
        {
            for (int y1 = -n; y1 < n; y1++)
            {
                for (int x2 = x1 + 1; x2 <= n; x2++)
                {
                    for (int y2 = y1 + 1; y2 <= n; y2++)
                    {
                        var area = Math.Abs(x2 - x1) * Math.Abs(y2 - y1);

                        if (area >= m)
                        {
                            Console.WriteLine($"({x1}, {y1}) ({x2}, {y2}) -> {area}");
                            hasAnswer = true;
                        }
                    }
                }
            }
        }

        if (hasAnswer == false)
        {
            Console.WriteLine("No");
        }
    }
}
