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

        Paypal pay1 = new Paypal("roger@example.com", 89.2, "Ecran");
        Paypal pay2 = new Paypal("laurie@example.com", 59.36, "Kit maquillage");

        pay1.AfficherDetails();
        pay2.AfficherDetails();

        Utilisateur user1 = new Utilisateur("Beni");

        user1.AjouterPaiement(cart1);
        user1.AjouterPaiement(cart2);
        user1.AjouterPaiement(cart3);
        user1.AjouterPaiement(pay1);
        user1.AjouterPaiement(pay2);

        user1.AfficherInfos();
    }
}
