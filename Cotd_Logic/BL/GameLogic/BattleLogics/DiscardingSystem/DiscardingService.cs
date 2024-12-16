using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.Common;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DiscardingSystem;

public delegate void CardDiscardedEventHandler(Card card);
public class DiscardingService
{
    public CardDiscardedEventHandler? CardDiscarded;

    Hand hand;
    DiscardPile discardPile;

    public void DiscardCard(Card card)
    {
        hand.RemoveCard(card);
        discardPile.AddCard(card);

        CardDiscarded?.Invoke(card);
    }

    public void DiscardHand()
    {
        foreach (Card card in hand)
        {
            DiscardCard(card);
        }
    }
}
