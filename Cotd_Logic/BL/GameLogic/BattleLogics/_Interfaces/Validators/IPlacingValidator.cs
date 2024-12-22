using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators
{
    public interface IPlacingValidator
    {
        bool ValidatePlacing(IPlacement placement, IPlaceable placeable);
    }
}