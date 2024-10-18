using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.DataAccessors.CardAccessors;

public class UnitCardAccessor : ICardAccessor<UnitCard>
{
    private readonly IUnitCardRepository _repo;

    public UnitCardAccessor(IUnitCardRepository repo)
    {
        _repo = repo;
    }

    public UnitCard GetCard(int id)
    {
        UnitCardData data = _repo.GetOne(id);

        return new UnitCard(data);
    }

    public List<UnitCard> GetCards()
    {
        return _repo.GetAll()
                    .Select(data => new UnitCard(data))
                    .ToList();
    }
}
