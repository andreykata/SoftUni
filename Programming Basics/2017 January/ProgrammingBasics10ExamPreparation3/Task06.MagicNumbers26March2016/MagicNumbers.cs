using System;
class MagicNumbers
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i1 = 1; i1 < 10; i1++)
        {
            for (int i2 = 1; i2 < 10; i2++)
            {
                for (int i3 = 1; i3 < 10; i3++)
                {
                    for (int i4 = 1; i4 < 10; i4++)
                    {
                        for (int i5 = 1; i5 < 10; i5++)
                        {
                            for (int i6 = 1; i6 < 10; i6++)
                            {
                                if (i1 * i2 * i3 * i4 * i5 * i6 == n)
                                {
                                    Console.Write("{0}{1}{2}{3}{4}{5} ",
                                        i1, i2, i3, i4, i5, i6);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
