using System;
using PizzaSharp.Metier;

namespace PizzaSharp.Appli
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingredient[] ingredientsRoyale = new Ingredient[3];
            ingredientsRoyale[0] = new Ingredient("pate", 1);
            ingredientsRoyale[1] = new Ingredient("sauce", 1);
            ingredientsRoyale[2] = new Ingredient("mozzarella", 2);
            Pizza royale = new Pizza("Royale", 5.60m, new Cercle(30), ingredientsRoyale);
            royale.AjouterSupplement(new Supplement("Champignon", 3, 1.20m));
            royale.AjouterSupplement(new Supplement("Thon", 1, 0.75m));

            royale.AfficherDetail();

            Commande[] commandes = new Commande[100];

            Commande cmdMargherita = new CommandeTelephone(10, "0123456789");

            Pizza margherita = new Pizza("Margherita", 7.80m, new Rectangle(15, 25), ingredientsRoyale);
            cmdMargherita.AjouterPizza(margherita);

            Ingredient[] ingredientsSpeciale = new Ingredient[4];
            ingredientsSpeciale[0] = new Ingredient("pate", 1);
            ingredientsSpeciale[1] = new Ingredient("sauce", 1);
            ingredientsSpeciale[2] = new Ingredient("oeuf", 1);
            ingredientsSpeciale[3] = new Ingredient("jambon", 2);
            Pizza speciale = new Pizza("Spéciale", 9.45m, new Cercle(20), ingredientsSpeciale);
            speciale.AjouterSupplement(new Supplement("Chorizo", 1, 1.20m));
            cmdMargherita.AjouterPizza(speciale);
            commandes[0] = cmdMargherita;

            Commande cmd4Saisons = new CommandeComptoir(8);
            Pizza quatreSaisons = new Pizza("4 saisons", 7.80m, new Cercle(25), ingredientsRoyale);
            cmd4Saisons.AjouterPizza(quatreSaisons);
            commandes[1] = cmd4Saisons;

            for (int i = 0; i < 2; i++)
            {
                commandes[i].AfficherDetail();
            }

            Console.ReadLine();
        }
    }
}
