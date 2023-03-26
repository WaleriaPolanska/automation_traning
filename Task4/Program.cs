namespace Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var card1 = new PaymentCard("card1", 0000000000000000,
                 123, new UserInfo("Jan" ,"Kowalski", new Address("Lesnaya", 11100, "Warsaw", "Poland" , 49, 209), "+48555555555"));
            var card2 = new PaymentCard("card2", 1111111111111111,
                 123, new UserInfo("Tomek" ,"Dupczynski", new Address("Solnechnaya", 11101, "Baranovichi", "Belarus", 8, 46 ), "+48555555556"));
            var card3 = new PaymentCard("card3", 2222222222222222,
                 123, new UserInfo("Zbigniew" ,"Romualdowicz", new Address("Pieski", 11111, "Kiev", "Ukraine" , 89, 107), "+48555555558"));
            var card4 = new PaymentCard("card4", 3333333333333333,
                 123, new UserInfo("Aleksander" ,"Zabowski", new Address("Horoshaya", 11102, "Dortmund", "Deutschland", 8, 20 ), "+48555555553" ));
            var card5 = new PaymentCard("card5", 4444444444444444,
                123, new UserInfo("Sabina" ,"Jaicuk", new Address("Grustnaya", 11103, "Paris", "France",  7, 19), "+48555555585"));


            var array = new[] {card1, card2, card3, card4, card5};

            foreach (var el in array)
            {
                el.GetCardInfo();
            }
        }
    }
}