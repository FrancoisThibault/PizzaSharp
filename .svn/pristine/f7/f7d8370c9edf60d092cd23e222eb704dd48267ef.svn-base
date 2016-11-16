using System;

namespace PizzaSharp.Metier
{
    public abstract class Commande : ICommande
    {
        private static int _nbrCommande = 0;
        private Pizza[] _pizzas;
        public int Numero { get; private set; }

        public virtual void AfficherDetail()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Commande numéro {0}", this.Numero);
            for (int i = 0; i < _pizzas.Length; i++)
            {
                _pizzas[i].AfficherDetail();
            }
            Console.WriteLine("Total de la commande : {0} euros", this.TotalCommande());
        }

        public virtual decimal TotalCommande()
        {
            decimal total = 0m;
            for (int i = 0; i < _pizzas.Length; i++)
            {
                total += _pizzas[i].GetPrix();
            }
            return total;
        }

        public void AjouterPizza(Pizza pizza)
        {
            int nbPizza = _pizzas.Length;
            Array.Resize<Pizza>(ref _pizzas, nbPizza + 1);
            _pizzas[nbPizza] = pizza;
        }

        protected Commande()
        {
            _nbrCommande++;
            _pizzas = new Pizza[0];
            this.Numero = _nbrCommande;
        }
    }
}