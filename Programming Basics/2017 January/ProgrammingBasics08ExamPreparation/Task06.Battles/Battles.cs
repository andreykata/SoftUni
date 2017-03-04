using System;
class Battles
{
    static void Main(string[] args)
    {
        var firstPokemonsCount = int.Parse(Console.ReadLine());
        var secondPokemonsCount = int.Parse(Console.ReadLine());
        var maxBattles = int.Parse(Console.ReadLine());
        var count = 0;

        for (int i1 = 1; i1 <= firstPokemonsCount; i1++)
        {
            for (int i2 = 1; i2 <= secondPokemonsCount; i2++)
            {
                if (maxBattles <= count)
                {
                    break;
                }

                Console.Write("({0} <-> {1}) ", i1, i2);
                count++;
            }
        }
    }
}
