using System;

namespace PizzaSharp.Metier
{
    public class Cercle : Forme
    {
        public int Diametre { get; private set; }

        public override double GetSurface()
        {
            return Math.Pow(this.Diametre / 2.0, 2.0) * Math.PI;
        }

        public Cercle(int diametre) 
            : base("ronde")
        {
            this.Diametre = diametre;
        }
    }
}