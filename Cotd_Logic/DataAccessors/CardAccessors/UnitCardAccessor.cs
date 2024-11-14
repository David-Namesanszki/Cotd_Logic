using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.DataAccessors.Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.DataAccessors.CardAccessors;

public class UnitCardAccessor : IDataAccessor<UnitCard>
{
    private readonly IUnitCardRepository _repo;

    public UnitCardAccessor(IUnitCardRepository repo)
    {
        _repo = repo;
    }

    public UnitCard GetOne(string id)
    {
        UnitCardData data = _repo.GetOne(id);

        return new UnitCard(data);
    }

    public List<UnitCard> GetAll()
    {
        return _repo.GetAll()
                    .Select(data => new UnitCard(data))
                    .ToList();
    }
}
