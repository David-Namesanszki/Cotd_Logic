using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DefendSystem.DefendBehaviours;

public class SimpleDefendBehaviour : IDefendBehaviour
{
	public void DefendWith(IDefender defender)
	{
		defender.IncreaseArmor(defender.DefenseValue);
	}
}
