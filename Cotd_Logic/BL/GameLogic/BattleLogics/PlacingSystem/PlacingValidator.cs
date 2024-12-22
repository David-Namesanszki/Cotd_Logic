using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.PlacingSystem;

public class PlacingValidator : IPlacingValidator
{
	public bool ValidatePlacing(IPlacement placement, IPlaceable placeable)
	{
		return placement.Item == null &&
			   placement.PlacementType == placeable.PlacementType;
	}
}
