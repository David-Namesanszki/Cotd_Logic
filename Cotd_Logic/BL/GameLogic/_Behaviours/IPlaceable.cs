using Cotd_Logic.Models.BoardTiles;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.PlacingSystem;

public interface IPlaceable
{
	public BoardTile BoardTile { get; set; }
}
