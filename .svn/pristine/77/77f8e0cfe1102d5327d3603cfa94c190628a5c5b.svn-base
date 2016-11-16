using System;

namespace PizzaSharp.Metier
{
    public class CommandeTelephone : Commande
    {
        public int Distance { get; private set; }
        public string Telephone { get; private set; }

        public override void AfficherDetail()
        {
            base.AfficherDetail();
            Console.WriteLine("Commandée par {0}, habitant à {1} km", this.Telephone, this.Distance);
        }

        public override decimal TotalCommande()
        {
            return base.TotalCommande() + this.Distance * 0.5m;
        }

        public CommandeTelephone(int distance, string telephone)
            : base()
        {
            this.Distance = distance;
            this.Telephone = telephone;
        }
    }
}