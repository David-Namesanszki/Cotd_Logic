using Cotd_Data._Interfaces;
using Cotd_Data.Models.GameInfos;
using Cotd_Logic.BL._Interfaces;
using Cotd_Logic.Models.GameInfos;

namespace Cotd_Logic.BL.DataAccessors;

public class GameAccessor : IDataAccessor<Game>
{
    private readonly IGameRepository _repo;

    public GameAccessor(IGameRepository repo)
    {
        _repo = repo;
    }

    public Game GetOne(string id)
    {
        GameData data = _repo.GetOne(id);

        return new Game();
    }

    public List<Game> GetAll()
    {
        return _repo.GetAll()
                    .Select(data => new Game())
                    .ToList();
    }
}
