using Cotd_Logic._Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics.UnlockingSystem;

public class CardUnlocker : ICardUnlocker
{
    private readonly IList<Card> _allCards;
    private readonly IList<string> _ownedCardIds;
    private readonly Random _random;

    public CardUnlocker(IList<Card> allCards, IList<string> ownedCardIds, Random random)
    {
        _allCards = allCards;
        _ownedCardIds = ownedCardIds;
        _random = random;
    }

    public Card UnlockRandomCard(CardTypes cardType)
    {
        IList<string> notOwnedCards = _allCards
            .Where(c => c.CardType == cardType)
            .Select(c => c.Id)
            .Except(_ownedCardIds).ToList();

        int randomIdx = _random.Next(notOwnedCards.Count);

        string randomCardId = notOwnedCards[randomIdx];

        return _allCards.FirstOrDefault(c => c.Id == randomCardId) ?? throw new KeyNotFoundException($"Card with ID {randomCardId} not found."); ;
    }
}
