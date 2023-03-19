namespace Task2;

public class PaymentCard
{
    public string CardName = "";
    public long CardNumber;
    public DateTime ExpirationDate;
    public string ClientName = "";
    public int CVV;

    public void Print()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Card Name: {CardName}\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Card Number: {CardNumber}\nExpiration Date: {ExpirationDate.ToString("MM/yy")}\nClient Name: {ClientName}\nCVV: {CVV}\n");
    }
}