using System;

namespace PizzaSharp.Metier
{
    public class CommandeComptoir : Commande
    {
        public int NumeroTable { get; private set; }

        public override void AfficherDetail()
        {
            base.AfficherDetail();
            Console.WriteLine("A servir à la table {0}", this.NumeroTable);
        }

        public CommandeComptoir(int numTable) 
            : base()
        {
            this.NumeroTable = numTable;
        }
    }
}