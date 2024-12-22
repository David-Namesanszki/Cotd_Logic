using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics.AttackSystem.AttackBehaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DefendSystem.DefendBehaviours;

public class BerserkerDefendBehaviour : IDefendBehaviour
{
	private readonly IAttackBehaviour _attackBehaviour;

	public BerserkerDefendBehaviour(IAttackBehaviour attackBehaviour)
	{
		_attackBehaviour = attackBehaviour;
	}

	public void DefendWith(IDefender defender)
	{
		if (defender is IAttacker attacker)
		{
			_attackBehaviour.AttackWith(attacker);
		}
		else
		{
			throw new InvalidOperationException("IDefender with BerserkerDefendBehaviour must implement IAttacker.");
		}
	}
}
