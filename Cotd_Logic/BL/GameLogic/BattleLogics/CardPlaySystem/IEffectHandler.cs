using Cotd_Logic.Models.Effects;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.CardPlaySystem
{
    public interface IEffectHandler
    {
        void HandleEffect(Effect effect, object? target = null);
    }
}