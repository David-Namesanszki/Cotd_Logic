namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

public enum PlacementType
{
    Melee,
    Ranged,
    Construction,
    Effect,
}

public interface IPlacement
{
    IPlaceable Item { get; }
	PlacementType PlacementType { get; }
    void Place(IPlaceable placeable);
}
