using Cotd_Data.Models.GameInfos;
using Cotd_Data.Repositories.GameInfoRepositories;
using Cotd_Logic.DataAccessors.Interfaces;
using Cotd_Logic.Models.GameInfos;

namespace Cotd_Logic.DataAccessors.GameInfoAccessors;

public class GameInfoAccessor : IDataAccessor<Game>
{
	private readonly IGameRepository _repo;

	public GameInfoAccessor(IGameRepository repo)
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
