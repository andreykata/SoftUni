using System;
class Grade
{
    static void Main(string[] args)
    {
        var studentsCount = int.Parse(Console.ReadLine());
        var between5And6 = 0;
        var betwwen4And5 = 0;
        var between3And4 = 0;
        var between2And3 = 0;
        var sumGrades = 0.0;

        for (int i = 0; i < studentsCount; i++)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 5)
            {
                between5And6++;
            }
            else if (grade >= 4)
            {
                betwwen4And5++;
            }
            else if (grade >= 3)
            {
                between3And4++;
            }
            else if (grade >= 2)
            {
                between2And3++;
            }

            sumGrades += grade;
        }

        Console.WriteLine("Top students: {0:0.00}%", between5And6 / (double)studentsCount * 100);
        Console.WriteLine("Between 4.00 and 4.99: {0:0.00}%", betwwen4And5 / (double)studentsCount * 100);
        Console.WriteLine("Between 3.00 and 3.99: {0:0.00}%", between3And4 / (double)studentsCount * 100);
        Console.WriteLine("Fail: {0:0.00}%", between2And3 / (double)studentsCount * 100);
        Console.WriteLine("Average: {0:0.00}", sumGrades / studentsCount);
    }
}