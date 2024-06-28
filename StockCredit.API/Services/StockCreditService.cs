using StockCredit.API.Models;
using StockCredit.API.Data;

namespace StockCredit.API.Services;

public interface IStockCreditService
{
    public List<Stocks> GetStocks();
    public List<Stocks> GetStocks(string duration);

    public List<Credits> GetCredits();

    public List<Credits> GetCredits(string duration);
}

public class StockCreditService : IStockCreditService
{
    Dictionary<string, int> dates = new Dictionary<string, int>
    {
        {"6m", -6},
        {"12m", -12},
        {"3y", -36},
        {"5y", -60},
    };
    public List<Credits> GetCredits()
    {
        List<Credits> credits = StocksCreditsMocks.creditsList;
        return credits;
    }

    public List<Credits> GetCredits(string duration)
    {
        List<Credits> credits = StocksCreditsMocks.creditsList;
        try
        {
            int range = dates[duration.ToLower()];

            DateTime ago = DateTime.Now.AddMonths(range);
            credits = credits.Where(x => x.Date >= ago).ToList();

            return credits;
        }
        catch (Exception)
        {
            throw new Exception();
        }
    }

    public List<Stocks> GetStocks()
    {
        List<Stocks> stocks = StocksCreditsMocks.stockList;
        return stocks;
    }

    public List<Stocks> GetStocks(string duration)
    {
        List<Stocks> stocks = StocksCreditsMocks.stockList;
        try
        {
            int range = dates[duration.ToLower()];

            DateTime ago = DateTime.Now.AddMonths(range);
            stocks = stocks.Where(x => x.Date >= ago).ToList();

            return stocks;
        }
        catch (Exception)
        {
            throw new Exception();
        }

    }
}