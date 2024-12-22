using Cotd_Logic._Interfaces.AttackSystem;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.AttackSystem.AttackBehaviours;

internal class IgnoreArmorAttackBehaviour : IAttackBehaviour
{
	private readonly IAttackTargetFinder _targetFinder;
	private readonly IAttackDamageCalculator _damageCalculator;

	public void AttackWith(IAttacker attacker)
	{
		IDamageable? target = _targetFinder.FindAttackTarget(attacker);
		int attackDamage = _damageCalculator.GetAttackDamage(attacker);

		target?.TakeDamage(attackDamage, true);
	}
}
