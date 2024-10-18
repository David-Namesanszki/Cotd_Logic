namespace Cotd_Logic.DataStorage.CardStorage.Interfaces
{
    public interface IConstructionCardStorage
    {
        void InsertCard(string name, string description, string image, string envoyCost, string turnsToBuild, string armor, string power);
        void RemoveCard(string id);
        void UpdateCard(string id, string name, string description, string image, string envoyCost, string turnsToBuild, string armor, string power);
    }
}