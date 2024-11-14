using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.DataAccessors.Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.DataAccessors.CardAccessors;

public class ConstructionCardAccessor : IDataAccessor<ConstructionCard>
{
    private readonly IConstructionCardRepository _repo;

    public ConstructionCardAccessor(IConstructionCardRepository repo)
    {
        _repo = repo;
    }

    public ConstructionCard GetOne(string id)
    {
        ConstructionCardData data = _repo.GetOne(id);

        return new ConstructionCard(data);
    }

    public List<ConstructionCard> GetAll()
    {
        return _repo.GetAll()
                    .Select(data => new ConstructionCard(data))
                    .ToList();
    }
}
