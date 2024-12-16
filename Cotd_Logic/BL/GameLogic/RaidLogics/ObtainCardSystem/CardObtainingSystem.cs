using Cotd_Logic.Models;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.BL.GameLogic.RaidLogics.ObtainCardSystem;

public class CardObtainingSystem : ICardObtainingSystem
{
	private Raid _raid;

	public CardObtainingSystem(Raid raid)
	{
		_raid = raid;
	}

	public void ObtainCard(Card card)
	{
		_raid.Deck.Add(card);
	}
}
