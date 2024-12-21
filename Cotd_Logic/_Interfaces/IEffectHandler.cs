using Cotd_Logic.BL.GameLogic._Behaviours;
using Cotd_Logic.Models.Effects;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.CardPlaySystem
{
    public interface IEffectHandler
    {
        void HandleEffect(Effect effect, ITargetable? target = null);
    }
}