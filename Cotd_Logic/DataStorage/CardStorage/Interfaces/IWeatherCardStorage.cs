namespace Cotd_Logic.DataStorage.CardStorage.Interfaces
{
    public interface IWeatherCardStorage
    {
        void InsertCard(string name, string description, string image, string envoyCost);
        void RemoveCard(string id);
        void UpdateCard(string id, string name, string description, string image, string envoyCost);
    }
}