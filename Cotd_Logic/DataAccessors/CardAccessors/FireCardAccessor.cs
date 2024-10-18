using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.DataAccessors.CardAccessors;

public class FireCardAccessor : ICardAccessor<FireCard>
{
    private readonly IFireCardRepository _repo;

    public FireCardAccessor(IFireCardRepository repo)
    {
        _repo = repo;
    }

    public FireCard GetCard(int id)
    {
        FireCardData data = _repo.GetOne(id);

        return new FireCard(data);
    }

    public List<FireCard> GetCards()
    {
        return _repo.GetAll()
                    .Select(data => new FireCard(data))
                    .ToList();
    }
}
