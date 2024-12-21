using Cotd_Data.ValueObjects;
using Cotd_Logic.BL.GameLogic._Behaviours;
using Cotd_Logic.Models.BoardPieces;

namespace Cotd_Logic.Models.BoardTiles;
public enum TeamSides
{
    Blue,
    Red,
    Neutral,
    Undefined
}

public enum BoardTileTypes
{
    Unit,
    Construction,
    Effect,
    Undefined,
}

public enum BoardTileOrientation
{
    Frontside,
    Backside,
	Undefined,
}

public class BoardTile : BoardObject, ITargetable
{
	public BoardTile(
        CubeCoord coords,
        BoardTileOrientation orientation,
        TeamSides teamSide,
        BoardTileTypes boardTileType
    )
	{
		Coords = coords;
		Orientation = orientation;
		TeamSide = teamSide;
		BoardTileType = boardTileType;
	}

    public int Row => Coords.Q;
    public CubeCoord Coords { get; set; }
    public BoardTileOrientation Orientation { get; set; } = BoardTileOrientation.Undefined;
	public TeamSides TeamSide { get; set; } = TeamSides.Undefined;
    public BoardTileTypes BoardTileType { get; set; } = BoardTileTypes.Undefined;
}
