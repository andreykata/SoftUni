using System;
class CurrencyConverter
{
    static void Main(string[] args)
    {
        var inputValue = decimal.Parse(Console.ReadLine());
        var inputCurrency = Console.ReadLine();
        var outputCurrency = Console.ReadLine();
        var result = 0M;

        if (inputCurrency == "BGN")
        {
            if (outputCurrency == "USD")
            {
                result = inputValue / 1.79549M;
                Console.WriteLine("{0:0.00} USD", result);
            }
            else if (outputCurrency == "EUR")
            {
                result = inputValue / 1.95583M;
                Console.WriteLine("{0:0.00} EUR", result);
            }
            else if (outputCurrency == "GBP")
            {
                result = inputValue / 2.53405M;
                Console.WriteLine("{0:0.00} GBP", result);
            }
        }
        else if (inputCurrency == "EUR")
        {
            if (outputCurrency == "BGN")
            {
                result = inputValue * 1.95583M;
                Console.WriteLine("{0:0.00} BGN", result);
            }
            else if (outputCurrency == "USD")
            {
                result = inputValue * (1.95583M / 1.79549M);
                Console.WriteLine("{0:0.00} USD", result);
            }
            else if (outputCurrency == "GBP")
            {
                result = inputValue * (1.95583M / 2.53405M);
                Console.WriteLine("{0:0.00} GBP", result);
            }
        }
        else if (inputCurrency == "USD")
        {
            if (outputCurrency == "BGN")
            {
                result = inputValue * 1.79549M;
                Console.WriteLine("{0:0.00} BGN", result);
            }
            else if (outputCurrency == "EUR")
            {
                result = inputValue * (1.79549M / 1.95583M);
                Console.WriteLine("{0:0.00} EUR", result);
            }
            else if (outputCurrency == "GBP")
            {
                result = inputValue * (1.79549M / 2.53405M);
                Console.WriteLine("{0:0.00} GBP", result);
            }
        }
    }
}