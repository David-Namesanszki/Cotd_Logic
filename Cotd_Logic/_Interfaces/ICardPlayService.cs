using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic._Interfaces
{
    public interface ICardPlayService
    {
        void PlayCard(Card card, IList<ITargetable?> targets);

    }
}