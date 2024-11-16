using Cotd_Data._Interfaces;
using Cotd_Data.Models.Cards;
using Cotd_Logic.BL._Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.BL.DataStorages;

public class CardStorage : IDataStorage<Card>
{
    private readonly ICardRepository _repo;

    public CardStorage(ICardRepository repo)
    {
        _repo = repo;
    }

    public void Save(Card entity)
    {
        _repo.Insert(entity.ToData());
    }

    public void Update(Card entity)
    {
        _repo.Update(entity.ToData());
    }

    public void Delete(Card entity)
    {
        _repo.Remove(entity.ToData());
    }
}
