using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.Repositories.CardRepositories.Interfaces
{
    public interface IDreamCardRepository : IBaseRepository<DreamCard>
	{
        DreamCard GetOne(int id);
        void UpdateCard(int id, string name, string description, string image, int envoyCost);
    }
}