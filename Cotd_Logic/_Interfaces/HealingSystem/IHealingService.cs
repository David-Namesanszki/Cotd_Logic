using Cotd_Logic.BL.GameLogic.BattleLogics.HealingSystem;
using Cotd_Logic.BL.GameLogic.Behaviours;

namespace Cotd_Logic._Interfaces.HealSystem
{
    public interface IHealingService
    {
        event HealedEventService? Healed;

        void Heal(IHealable healable, int amount);
    }
}