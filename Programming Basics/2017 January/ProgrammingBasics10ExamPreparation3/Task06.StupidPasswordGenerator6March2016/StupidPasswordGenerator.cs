using System;
class StupidPasswordGenerator
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var l = int.Parse(Console.ReadLine());

        for (int i1 = 1; i1 <= n; i1++)
        {
            for (int i2 = 1; i2 <= n; i2++)
            {
                for (char i3 = 'a'; i3 < 'a' + l; i3++)
                {
                    for (char i4 = 'a'; i4 < 'a' + l; i4++)
                    {
                        //for (int i5 = Math.Max(i1, i2) + 1; i5 <= n; i5++)
                        //{
                        //    Console.Write("{0}{1}{2}{3}{4} ", i1, i2, i3, i4, i5);
                        //}

                        for (int i5 = 1; i5 <= n; i5++)
                        {
                            if (i5 > i1 && i5 > i2)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i1, i2, i3, i4, i5);
                            }
                        }
                    }
                }
            }
        }
    }
}
