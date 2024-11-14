using Cotd_Data.Models.GameInfos;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Data.Repositories.GameInfoRepositories;
using Cotd_Logic.DataStorage.Interfaces;
using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.Games.Raids;
using Cotd_Logic.Models.Games.Resources;

namespace Cotd_Logic.DataStorage.GameInfoStorages;

public class GameStorage
{
	private readonly IGameRepository _repo;

	public GameStorage(IGameRepository repo)
	{
		_repo = repo;
	}

	public void Create(string name, Resource resources, List<Card> unlockedCards, Raid ongoingRaid)
	{
		GameData data = new GameData()
		{
			Name = name,
			Resources = resources.ToData(),
			UnlockedCardIds = unlockedCards.Select(x => x.Id).ToList(),
			OngoingRaid = ongoingRaid.ToData()
		};
		_repo.Insert(data);
	}

	public void Delete(int id)
	{
		GameData gameInfoData = _repo.GetOne(id);
		_repo.Remove(gameInfoData);
	}

	public void Update(int id, string name, string heartwood, string barkOre, string bloodSap)
	{
		int intHeartWood = int.Parse(heartwood);
		int intBarkOre = int.Parse(barkOre);
		int intBloodSap = int.Parse(bloodSap);

		_repo.UpdateGameInfo(id, name, intHeartWood, intBarkOre, intBloodSap);
	}
}
