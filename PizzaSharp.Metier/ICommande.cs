namespace PizzaSharp.Metier
{
    public interface ICommande
    {
        void AfficherDetail();
        decimal TotalCommande();
    }
}