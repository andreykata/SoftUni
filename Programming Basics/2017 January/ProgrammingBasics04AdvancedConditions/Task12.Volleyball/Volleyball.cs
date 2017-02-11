using System;
class Volleyball
{
    static void Main(string[] args)
    {
        var year = Console.ReadLine();
        var holidays = int.Parse(Console.ReadLine());
        var goHomeDays = int.Parse(Console.ReadLine());
        

        var weeksInSofia = 48 - goHomeDays;
        var gamesInSofia = weeksInSofia * (3 / 4.0);
        var homeGames = goHomeDays;
        var holidayGames = holidays * (2 / 3.0);

        var games = gamesInSofia + homeGames + holidayGames;

        if (year == "leap")
        {
            games += games * 0.15;
            // games = games + (games * 0.15);
        }
        Console.WriteLine(Math.Truncate(games));
        //Console.WriteLine(Math.Floor(games));
    }
}
