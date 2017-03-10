using System;
class MatchTickets
{
    static void Main(string[] args)
    {
        var buged = double.Parse(Console.ReadLine());
        var category = Console.ReadLine().ToLower();
        var countPeople = int.Parse(Console.ReadLine());
        var moneyLeft = 0.0;

        if (countPeople >= 50)
        {
            moneyLeft = 0.75 * buged;
        }
        else if (countPeople >= 25)
        {
            moneyLeft = 0.6 * buged;
        }
        else if (countPeople >= 10)
        {
            moneyLeft = buged / 2;
        }
        else if (countPeople >= 5)
        {
            moneyLeft = 0.4 * buged;
        }
        else if (countPeople >= 1)
        {
            moneyLeft = 0.25 * buged;
        }

        var moneyForTickets = 0.0;

        if (category == "normal")
        {
            moneyForTickets = countPeople * 249.99;
        }
        else
        {
            moneyForTickets = countPeople * 499.99;
        }

        var spendMoney = moneyLeft - moneyForTickets;
        if (spendMoney >= 0)
        {
            Console.WriteLine("Yes! You have {0:0.00} leva left.", spendMoney);
        }
        else
        {
            Console.WriteLine("Not enough money! You need {0:0.00} leva.", Math.Abs(spendMoney));
        }
    }
}
