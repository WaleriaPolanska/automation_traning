using System.ComponentModel.DataAnnotations;

namespace Task3;

public class PaymentCard
{
    private string CardName = "";
    private long CardNumber;
    private DateTime ExpirationDate;
    private string ClientName = "";
    private int CVV;

    public PaymentCard(string nameOfCard, long numberOfCard, string nameOfClient, int codeCVV)
    { 
        CardName = nameOfCard;
        CardNumber = numberOfCard;
        ClientName = nameOfClient;
        CVV = codeCVV ;
        ExpirationDate = GetCardExpirationDate();
    }

    public void GetCardInfo()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Card Name: {CardName}\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Card Number: {CardNumber}\nExpiration Date: {ExpirationDate.ToString("MM/yy")}\nClient Name: {ClientName}\nCVV: {CVV}\n");
    }
    
    private static DateTime GetCardExpirationDate()
    {
        return DateTime.Now.AddYears(4);
    }
}
