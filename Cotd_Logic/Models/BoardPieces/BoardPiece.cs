using Cotd_Logic.Models.BoardTiles;
using Cotd_Logic.Models.Buffs;
using Cotd_Logic.Models.Common;

namespace Cotd_Logic.Models.BoardPieces;

public delegate void BoardPieceDestroyedEventHandler(string boardPieceId);
public abstract class BoardPiece : Entity
{
    public event BoardPieceDestroyedEventHandler? Destroyed;

    public IList<Buff> Buffs { get; set; }
    public BoardTile BoardTile { get; set; }
    protected void OnDestroyed()
    {
        Destroyed?.Invoke(Id);
    }

    public override bool Equals(object? obj)
    {
        // Check if obj is null or not a BoardPiece
        if (obj is not BoardPiece boardPiece)
            return false;

        // Compare Ids for equality
        return boardPiece.Id == Id;
    }
}
