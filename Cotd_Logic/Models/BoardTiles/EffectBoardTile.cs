using Cotd_Data.ValueObjects;

namespace Cotd_Logic.Models.BoardTiles;

public enum TileEffects
{

}
public class EffectBoardTile : BoardTile
{
	public EffectBoardTile(
		CubeCoord coords,
		BoardTileOrientation orientation,
		TeamSides teamSide,
		BoardTileTypes boardTileType,
		IList<TileEffects> tileEffects
	) : base(coords, orientation, teamSide, boardTileType)
	{
		TileEffects = new List<TileEffects>(tileEffects);
	}

	public IList<TileEffects> TileEffects { get; set; }
}
