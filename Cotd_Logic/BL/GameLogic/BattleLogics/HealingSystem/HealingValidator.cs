using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.HealingSystem;

public class HealingValidator : IHealingValidator
{
	public bool ValidateHealing(IHealable healable, int amount)
	{
		return healable.CanBeHealed && amount >= 0;
	}
}
