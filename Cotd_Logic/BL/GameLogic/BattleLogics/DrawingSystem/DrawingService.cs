using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Services;
using Cotd_Logic.BL.GameLogic.BattleLogics.DefendSystem;
using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.Common;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DrawingSystem;

public delegate void CardDrawnEventHandler(Card card);
public class HandIsFullEventArgs : EventArgs
{
	public HandIsFullEventArgs(IHand hand)
	{
		Hand = hand;
	}

	public IHand Hand { get; }
}

public class DrawingService : IDrawingService
{
    Deck _deck;
    Hand _hand;
    DiscardPile _discardPile;

    public event Action? DiscardPileTransferred;
    public event EventHandler<HandIsFullEventArgs>? HandIsFull;
    public event CardDrawnEventHandler? CardDrawn;

	protected virtual void OnHandIsFull(IHand hand)
    {
        HandIsFull?.Invoke(this, new HandIsFullEventArgs(hand));
    }

    public void DrawSingleCard(IDrawPile drawPile, IHand hand, IDiscardPile)
    {
		if (_hand.IsFull)
		{
			HandIsFull?.Invoke();
			return;
		}
	}

    public void DrawMultipleCards(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            DrawSingleCard();
        }
    }

    public void DrawSingleCard()
    {
        if (_hand.IsFull)
        {
            HandIsFull?.Invoke();
            return;
        }

        if (_deck.IsEmpty)
        {
            ReplenishDeckFromDiscardPile();

            if (_deck.IsEmpty)
            {
                return;
            }
        }

        Card drawnCard = _deck.GetTopCard();

        TransferCardToHand(_deck, _hand, drawnCard);

        CardDrawn?.Invoke(drawnCard);
    }

    private void ReplenishDeckFromDiscardPile()
    {
        if (!_discardPile.IsEmpty)
        {
            _discardPile.TransferCards(_deck);
            DiscardPileTransferred?.Invoke();
        }
    }

    private void TransferCardToHand(Deck deck, Hand hand, Card card)
    {
        deck.RemoveCard(card);
        hand.AddCard(card);
    }
}
