using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics.AttackSystem;

namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Services
{
    public interface IAttackService
    {
		event EventHandler<AttackEventArgs>? Attacked;

		void AttackWith(IAttacker damager);
    }
}