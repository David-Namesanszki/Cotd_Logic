using Cotd_Logic.Models.BoardTiles;

namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

public interface IPlaceable
{
    public PlacementType PlacementType { get; }
}
