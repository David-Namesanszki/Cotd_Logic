using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DefendSystem;

public class DefendValidator : IDefendValidator
{
	public bool ValidateDefend(IDefender defender)
	{
		return defender != null && defender.CanDefend;
	}
}
