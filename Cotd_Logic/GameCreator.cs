using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.GameInfos;
using Cotd_Logic.Models.Games.Raids;
using Cotd_Logic.Models.Games.Resources;

namespace Cotd_Logic; 

public class GameCreator
{
	
	public void CreateNewGame(string name)
	{
		Resource resource = new Resource();
		Raid raid = new Raid();
		List<Card> unlockedCards = new List<Card>();
		Game game = new Game(name);
	}

	public void LoadGame(string id)
	{

	}
}
