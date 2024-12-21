using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics.UnlockingSystem;

public class CardUnlocker
{
    private readonly IList<Card> _allCards;
    private readonly Random _random;

    public CardUnlocker(IList<Card> allCards, Random random)
    {
        _allCards = allCards;
        _random = random;
    }

    public Card UnlockRandomCard(IList<Card> ownedCards, CardTypes cardType)
    {
        IList<Card> notOwnedCards = _allCards
            .Where(c => c.CardType == cardType)
            .Except(ownedCards).ToList();

        int randomIdx = _random.Next(notOwnedCards.Count);

        Card randomCard = notOwnedCards[randomIdx];

        ownedCards.Add(randomCard);

        return randomCard;
    }
}
