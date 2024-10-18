namespace Cotd_Logic.DataStorage.CardStorage.Interfaces
{
    public interface IFireCardStorage
    {
        void InsertCard(string name, string description, string image, string envoyCost, string fireCost);
        void RemoveCard(string id);
        void UpdateCard(string id, string name, string description, string image, string envoyCost, string fireCost);
    }
}