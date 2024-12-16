using Cotd_Logic.Models.BoardPieces;

namespace Cotd_Logic.Models.BoardTiles;

public class UnitTile : BoardTile
{
    public Unit? Unit { get; set; }
    public bool IsOccupied => Unit != null;

    public void PutDownUnit(Unit unit)
    {
        Unit = unit;
    }
}
