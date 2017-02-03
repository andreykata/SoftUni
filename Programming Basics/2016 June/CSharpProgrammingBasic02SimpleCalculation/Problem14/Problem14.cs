using System;
using System.Collections.Generic;

class Problem14
{
    static void Main(string[] args)
    {
        var inputValue = decimal.Parse(Console.ReadLine());
        var inputCurrency = Console.ReadLine();
        var outputCurrency = Console.ReadLine();

        Dictionary<string, decimal> dict = new Dictionary<string, decimal>()
        {
            { "BGN", 1 },
            { "USD", 1.79549M },
            { "EUR", 1.95583M },
            { "GBP", 2.53405M }
        };

        var result = dict[inputCurrency] / dict[outputCurrency] * inputValue;

        Console.WriteLine("{0:0.00} {1}", result, inputCurrency);
    }
}
