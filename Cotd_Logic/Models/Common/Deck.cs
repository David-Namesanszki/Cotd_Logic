using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.Models.Common;

public class Deck : CardPile
{
	public Card GetTopCard()
	{
		if (IsEmpty)
		{
			throw new InvalidOperationException("The pile is empty.");
		}

		return _cards[0];
	}
}
