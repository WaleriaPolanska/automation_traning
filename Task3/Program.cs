namespace Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var card1 = new PaymentCard("card1", 0000000000000000,
                "Jan Kowalski", 123);
            var card2 = new PaymentCard("card2", 1111111111111111,
                "Tomek Dupczynski", 123);
            var card3 = new PaymentCard("card3", 2222222222222222,
                "Zbigniew Romualdowicz", 123);
            var card4 = new PaymentCard("card4", 3333333333333333,
                "Aleksander Zabowski", 123);
            var card5 = new PaymentCard("card5", 4444444444444444,
                "Sabina Jaicuk", 123);


            var array = new[] {card1, card2, card3, card4, card5};

            foreach (var el in array)
            {
                el.GetCardInfo();
            }
        }
    }
}