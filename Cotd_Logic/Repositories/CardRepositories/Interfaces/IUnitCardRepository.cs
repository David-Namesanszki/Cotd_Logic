using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.Repositories.CardRepositories.Interfaces
{
    public interface IUnitCardRepository : IBaseRepository<UnitCard>
	{
        UnitCard GetOne(int id);
        void UpdateCard(int id, string name, string description, string image, int envoyCost, int turnsToFormation, int health, int armor, int power, in UnitTypes type);
    }
}