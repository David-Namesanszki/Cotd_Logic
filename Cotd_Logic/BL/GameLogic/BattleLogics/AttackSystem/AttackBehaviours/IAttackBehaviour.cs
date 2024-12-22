using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.AttackSystem.AttackBehaviours;

public interface IAttackBehaviour
{
	void AttackWith(IAttacker attacker);
}
