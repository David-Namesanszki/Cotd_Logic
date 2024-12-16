using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.Models.Common;

public class DiscardPile : CardPile
{
	public void TransferCards(Deck deck)
	{
		foreach (Card card in _cards)
		{
			deck.AddCard(card);
			_cards.Remove(card);
		}
	}
}
