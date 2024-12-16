using Cotd_Logic.Models.BoardPieces;

namespace Cotd_Logic.Models.BoardTiles;

public class ConstructionTile : BoardTile
{
    public Construction? Construction { get; set; }
    public bool IsOccupied => Construction != null;

    public void PutDownConstruction(Construction construction)
    {
        Construction = construction;
    }
}
