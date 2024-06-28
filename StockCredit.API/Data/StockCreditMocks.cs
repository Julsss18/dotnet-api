using StockCredit.API.Models;

namespace StockCredit.API.Data;

public class StocksCreditsMocks
{
    public static List<Stocks> stockList = new List<Stocks> {
        new Stocks{Id=1, Date= DateTime.ParseExact("11/14/2021", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=289.3},
        new Stocks{Id=2, Date= DateTime.ParseExact("08/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=168.46},
        new Stocks{Id=3, Date= DateTime.ParseExact("08/03/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=167.67},
        new Stocks{Id=4, Date= DateTime.ParseExact("09/26/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=187.75},
        new Stocks{Id=5, Date= DateTime.ParseExact("10/28/2021", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=472.07},
        new Stocks{Id=6, Date= DateTime.ParseExact("11/09/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=219.31},
        new Stocks{Id=7, Date= DateTime.ParseExact("12/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=243.81},
        new Stocks{Id=8, Date= DateTime.ParseExact("01/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=82.36},
        new Stocks{Id=9, Date= DateTime.ParseExact("02/15/2021", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=271.66},
        new Stocks{Id=10, Date= DateTime.ParseExact("03/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=497.2},
        new Stocks{Id=11, Date= DateTime.ParseExact("04/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=164.54},
        new Stocks{Id=12, Date= DateTime.ParseExact("05/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=82.51},
        new Stocks{Id=13, Date= DateTime.ParseExact("06/15/2021", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=289.23},
        new Stocks{Id=14, Date= DateTime.ParseExact("07/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=297.34},
        new Stocks{Id=15, Date= DateTime.ParseExact("08/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=198.92},
        new Stocks{Id=16, Date= DateTime.ParseExact("09/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=252.29},
        new Stocks{Id=17, Date= DateTime.ParseExact("10/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=168.16},
        new Stocks{Id=18, Date= DateTime.ParseExact("11/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=155.74},
        new Stocks{Id=19, Date= DateTime.ParseExact("12/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=75.57},
        new Stocks{Id=20, Date= DateTime.ParseExact("01/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=203.47},
        new Stocks{Id=21, Date= DateTime.ParseExact("02/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=115.68},
        new Stocks{Id=22, Date= DateTime.ParseExact("03/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=276.99},
        new Stocks{Id=23, Date= DateTime.ParseExact("04/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=23.98},
        new Stocks{Id=24, Date= DateTime.ParseExact("05/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=397.68},
        new Stocks{Id=25, Date= DateTime.ParseExact("06/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=114.85},
        new Stocks{Id=26, Date= DateTime.ParseExact("07/15/2021", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=42.8},
        new Stocks{Id=27, Date= DateTime.ParseExact("08/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=301.2},
        new Stocks{Id=28, Date= DateTime.ParseExact("09/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=114.01},
        new Stocks{Id=29, Date= DateTime.ParseExact("10/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=306.28},
        new Stocks{Id=30, Date= DateTime.ParseExact("11/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=422.37},
        new Stocks{Id=31, Date= DateTime.ParseExact("12/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=193.54},
        new Stocks{Id=32, Date= DateTime.ParseExact("01/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=243.41},
        new Stocks{Id=33, Date= DateTime.ParseExact("02/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=365.78},
        new Stocks{Id=34, Date= DateTime.ParseExact("03/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=299.73},
        new Stocks{Id=35, Date= DateTime.ParseExact("04/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=376.33},
        new Stocks{Id=36, Date= DateTime.ParseExact("05/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=372.77},
        new Stocks{Id=37, Date= DateTime.ParseExact("06/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=286.68},
    };


    public static List<Credits> creditsList = new List<Credits> {
        new Credits{Id=1, Date= DateTime.ParseExact("11/14/2021", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=289.3},
        new Credits{Id=2, Date= DateTime.ParseExact("08/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=168.46},
        new Credits{Id=3, Date= DateTime.ParseExact("08/03/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=167.67},
        new Credits{Id=4, Date= DateTime.ParseExact("09/26/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=187.75},
        new Credits{Id=5, Date= DateTime.ParseExact("10/28/2021", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=472.07},
        new Credits{Id=6, Date= DateTime.ParseExact("11/09/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=219.31},
        new Credits{Id=7, Date= DateTime.ParseExact("12/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=243.81},
        new Credits{Id=8, Date= DateTime.ParseExact("01/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=82.36},
        new Credits{Id=9, Date= DateTime.ParseExact("02/15/2021", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=271.66},
        new Credits{Id=10, Date= DateTime.ParseExact("03/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=497.2},
        new Credits{Id=11, Date= DateTime.ParseExact("04/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=164.54},
        new Credits{Id=12, Date= DateTime.ParseExact("05/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=82.51},
        new Credits{Id=13, Date= DateTime.ParseExact("06/15/2021", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=289.23},
        new Credits{Id=14, Date= DateTime.ParseExact("07/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=297.34},
        new Credits{Id=15, Date= DateTime.ParseExact("08/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=198.92},
        new Credits{Id=16, Date= DateTime.ParseExact("09/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=252.29},
        new Credits{Id=17, Date= DateTime.ParseExact("10/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=168.16},
        new Credits{Id=18, Date= DateTime.ParseExact("11/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=155.74},
        new Credits{Id=19, Date= DateTime.ParseExact("12/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=75.57},
        new Credits{Id=20, Date= DateTime.ParseExact("01/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=203.47},
        new Credits{Id=21, Date= DateTime.ParseExact("02/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=115.68},
        new Credits{Id=22, Date= DateTime.ParseExact("03/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=276.99},
        new Credits{Id=23, Date= DateTime.ParseExact("04/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=23.98},
        new Credits{Id=24, Date= DateTime.ParseExact("05/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=397.68},
        new Credits{Id=25, Date= DateTime.ParseExact("06/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=114.85},
        new Credits{Id=26, Date= DateTime.ParseExact("07/15/2021", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=42.8},
        new Credits{Id=27, Date= DateTime.ParseExact("08/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=301.2},
        new Credits{Id=28, Date= DateTime.ParseExact("09/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=114.01},
        new Credits{Id=29, Date= DateTime.ParseExact("10/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=306.28},
        new Credits{Id=30, Date= DateTime.ParseExact("11/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=422.37},
        new Credits{Id=31, Date= DateTime.ParseExact("12/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=193.54},
        new Credits{Id=32, Date= DateTime.ParseExact("01/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=243.41},
        new Credits{Id=33, Date= DateTime.ParseExact("02/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=365.78},
        new Credits{Id=34, Date= DateTime.ParseExact("03/15/2023", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=299.73},
        new Credits{Id=35, Date= DateTime.ParseExact("04/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=376.33},
        new Credits{Id=36, Date= DateTime.ParseExact("05/15/2022", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=372.77},
        new Credits{Id=37, Date= DateTime.ParseExact("06/15/2024", "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), Price=286.68},
    };
}