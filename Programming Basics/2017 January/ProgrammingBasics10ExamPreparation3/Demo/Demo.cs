using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Demo
    {
        static void Main(string[] args)
        {
            MyMethod();
        }

        private static void MyMethod()
        {
            string str = "Hello I'm string from Programming Basics";
            int count = 0;
            int startIndex = 0;

            while (true)
            {
                startIndex = str.IndexOf("o", startIndex);

                if (startIndex == -1)
                {
                    break;
                }

                Console.WriteLine("Index of string {0}", startIndex);

                count++;
                startIndex++;
            }

            Console.WriteLine(count);

            Console.WriteLine(str.Contains("Hello"));
            Console.WriteLine(str.Substring(10));
            Console.WriteLine(str.Substring(10, 5));
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Replace('l', '$'));
            Console.WriteLine(str.Remove(10, 5));
            Console.WriteLine(str.LastIndexOf('c'));

            // Arays
            Console.WriteLine("-------- Arays demo ---------");
            int lenght = 5;  // int.Parse(Console.ReadLine());
            int[] arr = new int[lenght];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 10;  // int.Parse(Console.ReadLine());
            }

            Console.WriteLine(arr.Sum());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Average());
            Console.WriteLine(arr[10]);
        }
    }
}
