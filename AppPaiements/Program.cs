using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {

        CarteCredit cart1 = new CarteCredit(15, "chargeur", 4896);
        CarteCredit cart2 = new CarteCredit(25,"chaise",9923);
        CarteCredit cart3 = new CarteCredit(86,"lunettes de ski", 2236);

        cart1.AfficherDetails();
        cart2.AfficherDetails();
        cart3.AfficherDetails();

    }
}