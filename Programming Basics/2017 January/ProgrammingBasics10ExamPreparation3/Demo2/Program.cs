using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 1, 1, 3, 4, 4, 5, 5, 5, 5, 2, 2, 8, 9, 11, 11, 11 };
        int startNumber;
        int max = 1;
        int maxNumber = 0;
        

        for (int i1 = 0; i1 < arr.Length - 1; i1++)
        {
            startNumber = arr[i1];
            int currnetMax = 1;

            for (int i2 = i1 + 1; i2 < arr.Length; i2++)
            {
                if (arr[i2] == startNumber)
                {
                    currnetMax++;
                }
                else
                {
                    break;
                }
            }

            if (currnetMax > max)
            {
                max = currnetMax;
                maxNumber = startNumber;
            }
        }

        for (int i = 0; i < max; i++)
        {
            Console.Write($"{maxNumber} ");
        }
    }
}
