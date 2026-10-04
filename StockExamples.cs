using System;
using System.Collections.Generic;

class Stock
{
    public string CompanyName { get; set; }
    public decimal CurrentPrice { get; set; }
    public decimal SharesOwned { get; set; }

    public decimal Worth
    {
        get { return CurrentPrice * SharesOwned; }
    }

    public Stock(string companyName, decimal currentPrice, decimal sharesOwned)
    {
        CompanyName = companyName;
        CurrentPrice = currentPrice;
        SharesOwned = sharesOwned;
    }

    public void DisplayStockInfo()
    {
        Console.WriteLine("Company: " + CompanyName);
        Console.WriteLine("Current Price: $" + CurrentPrice);
        Console.WriteLine("Shares Owned: " + SharesOwned);
        Console.WriteLine("Total Worth: $" + Worth);
        Console.WriteLine("-------------------------");
    }
}

class Program
{
    static void Main()
    {
        Stock apple = new Stock("Apple", 250.50m, 10);
        Stock microsoft = new Stock("Microsoft", 520.25m, 5);
        Stock nvidia = new Stock("NVIDIA", 185.75m, 8);

        List<Stock> portfolio = new List<Stock>();

        portfolio.Add(apple);
        portfolio.Add(microsoft);
        portfolio.Add(nvidia);

        Console.WriteLine("MY STOCK PORTFOLIO");
        Console.WriteLine("=========================");

        foreach (Stock stock in portfolio)
        {
            stock.DisplayStockInfo();
        }
    }
}
