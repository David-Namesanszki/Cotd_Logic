using Cotd_Data._Interfaces;
using Cotd_Logic._Interfaces;
using Cotd_Logic.BL.GameLogic.BattleLogics.PlacingSystem;
using Cotd_Logic.Models.BoardTiles;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.CardPlaySystem;

public class CardPlayService : ICardPlayService
{
    private IDataAccessor<Card> _cardAccessor;
    private readonly IEffectHandler _effectHandler;
    private readonly IBoardPiecePlacingService _placingService;

    public void PlayCard(Card card, object? target = null)
    {
        foreach (var effect in card.Effects)
        {
            _effectHandler.HandleEffect(effect, target);
        }

        if (card is UnitCard unitCard)
        {
            _placingService.PlaceBoardPiece(unitCard, target as BoardTile);
        }
    }
}
