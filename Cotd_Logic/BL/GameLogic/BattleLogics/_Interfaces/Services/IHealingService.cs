using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics.HealingSystem;

namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Services
{
    public interface IHealingService
    {
		event EventHandler<HealedEventArgs>? Healed;

		void Heal(IHealable healable, int amount);
    }
}