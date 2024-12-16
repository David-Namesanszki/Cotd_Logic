using Cotd_Data.ValueObjects;
using Cotd_Logic.Models.BoardPieces;
using Cotd_Logic.Models.Common;

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
}

public abstract class BoardTile : Entity
{
    public BoardPiece? BoardPiece { get; set; }
    public int Row => Coords.Q;
    public CubeCoord Coords { get; set; }
    public BoardTileOrientation Orientation { get; set; }
    public TeamSides TeamSide { get; set; } = TeamSides.Undefined;
    public BoardTileTypes BoardTileType { get; set; } = BoardTileTypes.Undefined;
}
