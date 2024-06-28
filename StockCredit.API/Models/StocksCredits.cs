namespace StockCredit.API.Models;

public class Stocks
{
    public int Id { get; set; }

    public required DateTime Date { get; set; }

    public required double Price { get; set; }
}

public class Credits
{
    public int Id { get; set; }

    public required DateTime Date { get; set; }

    public required double Price { get; set; }
}