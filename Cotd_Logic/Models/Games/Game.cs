using Cotd_Data.Models.GameInfos;
using Cotd_Logic.Models.Captains;
using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.Games.Raids;
using Cotd_Logic.Models.Games.Resources;

namespace Cotd_Logic.Models.GameInfos;

public class Game
{
	private ICollection<string> _unlockedCardIds = [];
	private ICollection<string> _unlockedCaptainIds = [];

	public Game()
    {
    }

    public Game(GameData gameData)
    {
        Id = gameData.Id;
        Name = gameData.Name;
        Resources = new Resource(gameData.Resources);
		_unlockedCardIds = gameData.UnlockedCardIds;
		_unlockedCaptainIds = gameData.UnlockedCaptainIds;
		OngoingRaid = gameData.OngoingRaid != null ? new Raid(gameData.OngoingRaid) : null;
	}

	public Game(string name)
	{
		Name = name;
	}

	public string Id { get; set; } = Guid.NewGuid().ToString();
	public string Name { get; set; } = string.Empty;
	public Resource Resources { get; set; } = new Resource();
	public ICollection<Card> UnlockedCards { get; } = [];
	public ICollection<Captain> UnlockedCaptains { get; } = [];
	public Raid? OngoingRaid { get; set; } = null;

	public GameData ToData()
	{
		return new GameData()
		{
			Id = Id,
			Name = Name,
			UnlockedCaptainIds = UnlockedCaptains.Select(x => x.Id).ToList(),
			UnlockedCardIds = UnlockedCards.Select(x => x.Id).ToList(),
			OngoingRaid = OngoingRaid?.ToData(),
			Resources = Resources.ToData()
		};
	}

    public void LoadUnlockedCards(List<Card> cards)
    {
        foreach (var cardId in _unlockedCardIds)
        {
            Card card = cards.FirstOrDefault(c => c.Id == cardId) ?? throw new ArithmeticException($"No card with this id: {cardId}"); ;
			UnlockedCards.Add(card);
        }
    }

	public void LoadUnlockedCaptains(List<Captain> captains)
	{
		foreach (var captainId in _unlockedCaptainIds)
		{
			Captain captain = captains.FirstOrDefault(c => c.Id == captainId) ?? throw new ArithmeticException($"No captain with this id: {captainId}"); ;
			UnlockedCaptains.Add(captain);
		}
	}
}
