using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.DataAccessors.CardAccessors;

public class ConstructionCardAccessor : ICardAccessor<ConstructionCard>
{
    private readonly IConstructionCardRepository _repo;

    public ConstructionCardAccessor(IConstructionCardRepository repo)
    {
        _repo = repo;
    }

    public ConstructionCard GetCard(int id)
    {
        ConstructionCardData data = _repo.GetOne(id);

        return new ConstructionCard(data);
    }

    public List<ConstructionCard> GetCards()
    {
        return _repo.GetAll()
                    .Select(data => new ConstructionCard(data))
                    .ToList();
    }
}
