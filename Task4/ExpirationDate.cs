namespace Task4;

public class ExpirationDate
{
    public int Month { get; }

    public int Year { get; }

    public ExpirationDate()
    {
        var expirationDate = GetCardExpirationDate();
        Month = expirationDate.Month;
        Year = expirationDate.Year;
    }
    private static DateTime GetCardExpirationDate()
    {
        return DateTime.Now.AddYears(4);
    }
}


