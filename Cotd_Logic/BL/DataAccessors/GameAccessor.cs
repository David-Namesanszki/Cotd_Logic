using Cotd_Data._Interfaces;
using Cotd_Data.Models.GameInfos;
using Cotd_Logic._Interfaces;
using Cotd_Logic.Models;

namespace Cotd_Logic.BL.DataAccessors;

public class GameAccessor : IDataAccessor<RiftBase>
{
    private readonly IGameRepository _repo;

    public GameAccessor(IGameRepository repo)
    {
        _repo = repo;
    }

    public RiftBase GetOne(string id)
    {
        GameData data = _repo.GetOne(id);

        return new RiftBase();
    }

    public List<RiftBase> GetAll()
    {
        return _repo.GetAll()
                    .Select(data => new RiftBase())
                    .ToList();
    }
}
