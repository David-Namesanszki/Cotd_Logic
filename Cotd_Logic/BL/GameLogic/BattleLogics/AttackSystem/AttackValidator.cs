using Cotd_Logic._Interfaces.AttackSystem;
using Cotd_Logic.BL.GameLogic.Behaviours;
using Cotd_Logic.Models.BoardPieces;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.AttackSystem;

public class AttackValidator : IAttackValidator
{
	public bool IsValidAttacker(BoardPiece boardPiece)
	{
		return boardPiece is IAttacker attacker && attacker.CanAttack;
	}
}
