using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    class CarteCredit : Paiement
    {

        public int NumeroCarte { get; set; }

        public CarteCredit(double montant, string description, int carte) : base (montant, description)
        {
            NumeroCarte = carte;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"{Montant} est le montant du {Description}, et le numero de la carte est {NumeroCarte}");
        }

    }
}
