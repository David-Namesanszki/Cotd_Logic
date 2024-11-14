using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.DataAccessors.Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.DataAccessors.CardAccessors;

public class DreamCardAccessor : IDataAccessor<DreamCard>
{
    private readonly IDreamCardRepository _repo;

    public DreamCardAccessor(IDreamCardRepository repo)
    {
        _repo = repo;
    }

    public DreamCard GetOne(string id)
    {
        DreamCardData data = _repo.GetOne(id);

        return new DreamCard(data);
    }

    public List<DreamCard> GetAll()
    {
        return _repo.GetAll()
                    .Select(data => new DreamCard(data))
                    .ToList();
    }
}
