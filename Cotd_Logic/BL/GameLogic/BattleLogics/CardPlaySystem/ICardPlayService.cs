using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.CardPlaySystem
{
    public interface ICardPlayService
    {
        void PlayCard(Card card, object? target = null);
    }
}