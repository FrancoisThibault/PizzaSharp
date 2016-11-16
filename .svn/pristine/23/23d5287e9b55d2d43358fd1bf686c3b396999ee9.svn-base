namespace PizzaSharp.Metier
{
    public class Rectangle : Forme
    {
        public int Hauteur { get; private set; }
        public int Largeur { get; private set; }

        public override double GetSurface()
        {
            return this.Largeur * this.Hauteur;
        }

        public Rectangle(int largeur, int hauteur) 
            : base("rectangulaire")
        {
            this.Hauteur = hauteur;
            this.Largeur = largeur;
        }
    }
}