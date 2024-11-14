using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.DataAccessors.Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.DataAccessors.CardAccessors;

public class FireCardAccessor : IDataAccessor<FireCard>
{
    private readonly IFireCardRepository _repo;

    public FireCardAccessor(IFireCardRepository repo)
    {
        _repo = repo;
    }

    public FireCard GetOne(string id)
    {
        FireCardData data = _repo.GetOne(id);

        return new FireCard(data);
    }

    public List<FireCard> GetAll()
    {
        return _repo.GetAll()
                    .Select(data => new FireCard(data))
                    .ToList();
    }
}
