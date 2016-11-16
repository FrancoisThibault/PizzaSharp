namespace PizzaSharp.Metier
{
    public class Supplement : Ingredient
    {
        public decimal Prix { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format(" + {0} euros", this.Prix * this.Quantite);
        }

        public Supplement(string nom, int quantite, decimal prix) 
            : base(nom, quantite)
        {
            this.Prix = prix;
        }
    }
}