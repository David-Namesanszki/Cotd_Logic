using Cotd_Data._Interfaces;
using Cotd_Logic.BL._Interfaces;
using Cotd_Logic.Models.GameInfos;

namespace Cotd_Logic.BL.DataStorages;

public class GameStorage : IDataStorage<Game>
{
    private readonly IGameRepository _repo;

    public GameStorage(IGameRepository repo)
    {
        _repo = repo;
    }

    public void Delete(Game entity)
    {
        _repo.Remove(entity.ToData());
    }

    public void Save(Game entity)
    {
        _repo.Insert(entity.ToData());
    }

    public void Update(Game entity)
    {
        _repo.Update(entity.ToData());
    }
}
