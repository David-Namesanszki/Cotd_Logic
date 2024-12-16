using Cotd_Logic.Models.Cards;
using System.Collections;

namespace Cotd_Logic.Models.Common;

public class CardPile : IEnumerable<Card>
{
	protected readonly List<Card> _cards = new();

	public IReadOnlyList<Card> Cards => _cards.AsReadOnly();
	public int Size => _cards.Count;
	public bool IsEmpty => Size == 0;

	public virtual void AddCard(Card card)
	{
		_cards.Add(card);
	}

	public void RemoveCard(Card card)
	{
		if (!_cards.Remove(card))
		{
			throw new KeyNotFoundException($"No card found in the card pile with ID: {card.Id}");
		}
	}

	public IEnumerator<Card> GetEnumerator()
	{
		return _cards.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
