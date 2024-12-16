using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.Models.Common;

public class Hand : CardPile
{
	public int MaxSize { get; }
	public bool IsFull => Size >= MaxSize;

	public Hand(int maxSize)
	{
		MaxSize = maxSize;
	}

	public override void AddCard(Card card)
	{
		if (IsFull)
		{
			throw new InvalidOperationException("The hand is full.");
		}
		_cards.Add(card);
	}
}
