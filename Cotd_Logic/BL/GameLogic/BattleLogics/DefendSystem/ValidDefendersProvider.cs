using Cotd_Logic._Interfaces;
using Cotd_Logic._Interfaces.DefendSystem;
using Cotd_Logic.BL.GameLogic._Behaviours;
using Cotd_Logic.BL.GameLogic.Behaviours;
using Cotd_Logic.Models.BoardPieces;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DefendSystem;

public class ValidDefendersProvider : IValidDefendersProvider
{
	public IList<IDefender> GetValidDefenders(IList<BoardPiece> boardPieces)
	{
		return boardPieces
			.OfType<IDefender>()
			.Where(defender => defender.CanDefend)
			.ToList();
	}
}
