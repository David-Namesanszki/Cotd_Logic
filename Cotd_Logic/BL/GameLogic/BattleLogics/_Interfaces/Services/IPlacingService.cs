using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics.PlacingSystem;

namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Services
{
	public interface IPlacingService
    {
		event EventHandler<BoardPiecePlacedEventArgs>? Placed;

		void Place(IPlacement placement, IPlaceable placeable);
    }
}