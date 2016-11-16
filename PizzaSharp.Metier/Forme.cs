namespace PizzaSharp.Metier
{
    public abstract class Forme
    {
        public string Libelle { get; private set; }

        public abstract double GetSurface();

        protected Forme(string libelle)
        {
            this.Libelle = libelle;
        }
    }
}