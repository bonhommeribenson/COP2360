using System;
using System.Collections.Generic;

class Stock
{
    public string Name;
    public double Price;
}

class Program
{
    static void Main()
    {
        Stock stock1 = new Stock();
        stock1.Name = "Apple";
        stock1.Price = 250.50;

        Stock stock2 = new Stock();
        stock2.Name = "Microsoft";
        stock2.Price = 520.25;

        List<Stock> stocks = new List<Stock>();

        stocks.Add(stock1);
        stocks.Add(stock2);

        foreach (Stock stock in stocks)
        {
            Console.WriteLine("Company: " + stock.Name);
            Console.WriteLine("Price: $" + stock.Price);
        }
    }
}
