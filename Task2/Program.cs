namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var currentDate = DateTime.Now;
            var expirationDate = GetCardExpirationDate(currentDate);
            var card1 = new PaymentCard
            {
                CardName = "card1",
                CardNumber = 0000000000000000,
                ExpirationDate = expirationDate,
                ClientName = "Jan Kowalski",
                CVV = 123
            };
            var card2 = new PaymentCard
            {
                CardName = "card2",
                CardNumber = 1111111111111111,
                ExpirationDate = expirationDate,
                ClientName = "Tomek Dupczynski",
                CVV = 321
            };
            var card3 = new PaymentCard
            {
                CardName = "card3",
                CardNumber = 2222222222222222,
                ExpirationDate = expirationDate,
                ClientName = "Zbigniew Romualdowicz",
                CVV = 231
            };
            var card4 = new PaymentCard
            {
                CardName = "card4",
                CardNumber = 3333333333333333,
                ExpirationDate = expirationDate,
                ClientName = "Aleksander Zabowski",
                CVV = 132
            };
            var card5 = new PaymentCard
            {
                CardName = "card5",
                CardNumber = 4444444444444444,
                ExpirationDate = expirationDate,
                ClientName = "Sabina Jaicuk",
                CVV = 122
            };
            var array = new [] {card1, card2, card3, card4, card5};
            
            foreach (var el in array)
            {
                el.Print();
            }
        }
        
        private static DateTime GetCardExpirationDate(DateTime currentDate)
        {
            return currentDate.AddYears(4);
        }
    }
}