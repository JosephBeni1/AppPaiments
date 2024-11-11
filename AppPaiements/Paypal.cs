using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal : Paiement
    {
        public string Courriel { get; set; }


        public Paypal(string email, double montant, string description) : base(montant, description)
        {
            Courriel = email;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"l'email de ce compte est {Courriel}, le montant de {Description} est {Montant}");
        }

    }
}
