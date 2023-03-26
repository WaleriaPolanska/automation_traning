namespace Task4;

public class PaymentCard
{
    public string CardName { get; }
    public long CardNumber { get; }
    public ExpirationDate ExpirationDate { get; }
    public string ClientName { get; }
    public int CVV { get; }

    public UserInfo UserInfo { get; }

    public PaymentCard(string nameOfCard, long numberOfCard, int codeCVV, UserInfo userInfo)
    {
        CardName = nameOfCard;
        CardNumber = numberOfCard;
        ClientName = userInfo.Name + " " + userInfo.LastName;
        CVV = codeCVV;
        ExpirationDate = new ExpirationDate();
        UserInfo = userInfo;
    }

    public void GetCardInfo()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Card Name: {CardName}\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(
            $"Card Number: {CardNumber}\nExpiration Date: {ExpirationDate.Month}/{ExpirationDate.Year} \nClient Name: {ClientName}\nCVV: {CVV}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("User info:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{UserInfo.Name} {UserInfo.LastName}\n{UserInfo.Address.Country} {UserInfo.Address.City} {UserInfo.Address.Postcode}\nStreet: {UserInfo.Address.Street}\n{UserInfo.Address.BuildingNumber}/{UserInfo.Address.Apartment}\nPhone: {UserInfo.Phone}\n\n");
    }
}