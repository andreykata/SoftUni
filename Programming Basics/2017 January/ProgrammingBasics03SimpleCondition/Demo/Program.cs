using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var color = "red";
            var number = 1;
            Console.WriteLine("Before If");

            if (color == "red")
            {
                number = 5;
                Console.WriteLine("Tomato");
            }
            else  if (color == "yellow")
            {
                Console.WriteLine("Bannana");
            }
            else if (color == "green")
            {
                Console.WriteLine("Kiwi");
            }
            else
            {
                Console.WriteLine("Some another fruit");
            }

            Console.WriteLine("");
            Console.WriteLine(number);
        }
    }
}
