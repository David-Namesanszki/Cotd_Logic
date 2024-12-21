using Cotd_Logic._Interfaces;
using Cotd_Logic._Interfaces.HealingSystem;
using Cotd_Logic.BL.GameLogic._Behaviours;
using Cotd_Logic.BL.GameLogic.Behaviours;
using Cotd_Logic.Models.BoardPieces;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.HealingSystem;

public class ValidHealablesProvider : IValidHealablesProvider
{
	public IList<IHealable> GetValidHealables(IList<BoardPiece> boardPieces)
	{
		return boardPieces
			.OfType<IHealable>()
			.Where(healable => healable.CanBeHealed)
			.ToList();
	}
}
