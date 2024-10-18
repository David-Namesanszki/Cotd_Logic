namespace Cotd_Logic.DataStorage.CardStorage.Interfaces
{
    public interface IUnitCardStorage
    {
        void InsertCard(string name, string description, string image, string envoyCost, string turnsToFormation, string health, string armor, string power, string unitType);
        void RemoveCard(string id);
        void UpdateCard(string id, string name, string description, string image, string envoyCost, string turnsToFormation, string health, string armor, string power, string unitType);
    }
}