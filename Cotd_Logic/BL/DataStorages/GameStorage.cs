using Cotd_Data._Interfaces;
using Cotd_Logic._Interfaces;
using Cotd_Logic.Models;

namespace Cotd_Logic.BL.DataStorages;

public class GameStorage : IDataStorage<RiftBase>
{
    private readonly IGameRepository _repo;

    public GameStorage(IGameRepository repo)
    {
        _repo = repo;
    }

    public void Delete(RiftBase entity)
    {
        _repo.Remove(entity.ToData());
    }

    public void Save(RiftBase entity)
    {
        _repo.Insert(entity.ToData());
    }

    public void Update(RiftBase entity)
    {
        _repo.Update(entity.ToData());
    }
}
