using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.DataAccessors.CardAccessors;

public class DreamCardAccessor : ICardAccessor<DreamCard>
{
    private readonly IDreamCardRepository _repo;

    public DreamCardAccessor(IDreamCardRepository repo)
    {
        _repo = repo;
    }

    public DreamCard GetCard(int id)
    {
        DreamCardData data = _repo.GetOne(id);

        return new DreamCard(data);
    }

    public List<DreamCard> GetCards()
    {
        return _repo.GetAll()
                    .Select(data => new DreamCard(data))
                    .ToList();
    }
}
