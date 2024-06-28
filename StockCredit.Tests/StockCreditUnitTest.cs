using StockCredit.API.Services;

namespace StockCredit.Tests;

public class StockCreditUnitTest
{
    [Fact]
    public void GetAllCredits_WithOutDuration()
    {
        var stockCreditService = new StockCreditService();
        var credits = stockCreditService.GetStocks();

        Assert.NotNull(credits);
    }

    [Fact]
    public void GetCredits_With6MonthsDuration()
    {
        var stockCreditService = new StockCreditService();
        var credits = stockCreditService.GetStocks("6M");
        DateTime ago = DateTime.Now.AddMonths(-6);
        credits = credits.Where(x => x.Date < ago).ToList();

        Assert.Empty(credits);
    }

    [Fact]
    public void GetCredits_With12MonthsDuration()
    {
        var stockCreditService = new StockCreditService();
        var credits = stockCreditService.GetStocks("12m");
        DateTime ago = DateTime.Now.AddMonths(-12);
        credits = credits.Where(x => x.Date < ago).ToList();

        Assert.Empty(credits);
    }

    [Fact]
    public void GetCredits_With3YearsDuration()
    {
        var stockCreditService = new StockCreditService();
        var credits = stockCreditService.GetStocks("3y");
        DateTime ago = DateTime.Now.AddMonths(-36);
        credits = credits.Where(x => x.Date < ago).ToList();

        Assert.Empty(credits);
    }

    [Fact]
    public void GetCredits_With5YearsDuration()
    {
        var stockCreditService = new StockCreditService();
        var credits = stockCreditService.GetStocks("5y");
        DateTime ago = DateTime.Now.AddMonths(-60);
        credits = credits.Where(x => x.Date < ago).ToList();

        Assert.Empty(credits);
    }

    [Fact]
    public void GetAllStocks_WithOutDuration()
    {
        var stockCreditService = new StockCreditService();
        var stocks = stockCreditService.GetStocks();

        Assert.NotNull(stocks);
    }

    [Fact]
    public void GetStocks_With6MonthsDuration()
    {
        var stockCreditService = new StockCreditService();
        var stocks = stockCreditService.GetStocks("6M");
        DateTime ago = DateTime.Now.AddMonths(-6);
        stocks = stocks.Where(x => x.Date < ago).ToList();

        Assert.Empty(stocks);
    }

    [Fact]
    public void GetStocks_With12MonthsDuration()
    {
        var stockCreditService = new StockCreditService();
        var stocks = stockCreditService.GetStocks("12m");
        DateTime ago = DateTime.Now.AddMonths(-12);
        stocks = stocks.Where(x => x.Date < ago).ToList();

        Assert.Empty(stocks);
    }

    [Fact]
    public void GetStocks_With3YearsDuration()
    {
        var stockCreditService = new StockCreditService();
        var stocks = stockCreditService.GetStocks("3y");
        DateTime ago = DateTime.Now.AddMonths(-36);
        stocks = stocks.Where(x => x.Date < ago).ToList();

        Assert.Empty(stocks);
    }

    [Fact]
    public void GetStocks_With5YearsDuration()
    {
        var stockCreditService = new StockCreditService();
        var stocks = stockCreditService.GetStocks("5y");
        DateTime ago = DateTime.Now.AddMonths(-60);
        stocks = stocks.Where(x => x.Date < ago).ToList();

        Assert.Empty(stocks);
    }
}