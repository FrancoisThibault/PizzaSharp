using System;

namespace PizzaSharp.Metier
{
    public class Pizza : IPizza
    {
        #region Propriétés
        public string Nom { get; set; }
        public decimal PrixBase { get; set; }

        private Ingredient[] _ingredients;
        public Forme Forme { get; set; }
        #endregion

        #region Méthodes
        public void AfficherDetail()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("{0}, de forme {1} et d'une surface de {2:F} cm².", this.Nom, this.Forme.Libelle, this.Forme.GetSurface());
            Console.WriteLine("Le prix de base est de {0} euros.", this.PrixBase);
            for (int i = 0; i < _ingredients.Length; i++)
            {
                Console.WriteLine(_ingredients[i].ToString());
            }
            Console.WriteLine("Le prix total est de {0} euros.", this.GetPrix());
        }

        public decimal GetPrix()
        {
            decimal prix = this.PrixBase;

            for (int i = 0; i < _ingredients.Length; i++)
            {
                if (_ingredients[i] is Supplement)
                {
                    prix += ((Supplement)_ingredients[i]).Prix * _ingredients[i].Quantite;
                }
            }

            return prix;
        }

        public double GetSurface()
        {
            return this.Forme.GetSurface();
        }

        public void AjouterSupplement(Supplement supplement)
        {
            int nbIngredient = _ingredients.Length;
            Array.Resize<Ingredient>(ref _ingredients, nbIngredient + 1);
            _ingredients[nbIngredient] = supplement;
        }

        #endregion

        #region Constructeurs
        public Pizza(string nom, decimal prixBase, Forme forme)
            : this(nom, prixBase, forme, new Ingredient[0])
        { }

        public Pizza(string nom, decimal prixBase, Forme forme, Ingredient[] ingredients)
        {
            this.Nom = nom;
            this.PrixBase = prixBase;
            this.Forme = forme;
            _ingredients = ingredients;
        }
        #endregion
    }
}