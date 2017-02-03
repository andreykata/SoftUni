using System;
class Program
{
    static void Main(string[] args)
    {
        var data = Console.ReadLine();
        DateTime birhtday = DateTime.ParseExact(data, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
        birhtday = birhtday.AddDays(1000);
        Console.WriteLine(birhtday.ToString("dd-MM-yyyy"));
    }
}