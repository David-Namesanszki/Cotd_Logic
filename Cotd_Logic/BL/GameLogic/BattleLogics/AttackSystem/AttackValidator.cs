using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators;
using Cotd_Logic.Models.BoardPieces;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.AttackSystem;

public class AttackValidator : IAttackValidator
{
	public bool IsValidAttacker(IAttacker attacker)
	{
		return attacker.CanAttack;
	}
}
