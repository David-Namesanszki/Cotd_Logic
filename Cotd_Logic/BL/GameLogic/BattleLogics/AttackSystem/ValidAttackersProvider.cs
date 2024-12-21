using Cotd_Logic._Interfaces;
using Cotd_Logic._Interfaces.AttackSystem;
using Cotd_Logic.BL.GameLogic._Behaviours;
using Cotd_Logic.BL.GameLogic.Behaviours;
using Cotd_Logic.Models.BoardPieces;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.AttackSystem;

public class ValidAttackersProvider : IValidAttackersProvider
{
	public IList<IAttacker> GetValidAttackers(IList<BoardPiece> boardPieces)
	{
		return boardPieces
			.OfType<IAttacker>()
			.Where(attacker => attacker.CanAttack)
			.ToList();
	}
}
