using Cotd_Data.ValueObjects;
using Cotd_Logic.Models.BoardPieces;

namespace Cotd_Logic.Models.BoardTiles;

public class PlacementBoardTile : BoardTile
{
	public PlacementBoardTile(CubeCoord coords, BoardTileOrientation orientation, TeamSides teamSide, BoardTileTypes boardTileType) : base(coords, orientation, teamSide, boardTileType)
	{
	}

    public BoardPiece? BoardPiece { get; set; }
	public bool IsOccupied => BoardPiece != null;
}
