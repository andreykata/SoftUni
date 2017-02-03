using System;
class Hospital
{
    static void Main(string[] args)
    {
        var days = int.Parse(Console.ReadLine());

        var treated = 0;
        var unTreated = 0;
        var doctors = 7;

        for (int i = 1; i <= days; i++)
        {
            var patients = int.Parse(Console.ReadLine());

            if (i % 3 == 0)
            {
                if (unTreated > treated)
                {
                    doctors++;
                }
            }

            if (patients > doctors)
            {
                treated += doctors;
                unTreated += patients - doctors;
            }
            else
            {
                treated += patients;
            }
        }

        Console.WriteLine($"Treated patients: {treated}.");
        Console.WriteLine($"Untreated patients: {unTreated}.");
    }
}