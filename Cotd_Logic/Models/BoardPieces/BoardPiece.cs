using Cotd_Logic.BL.GameLogic._Behaviours;
using Cotd_Logic.Models.BoardTiles;
using Cotd_Logic.Models.Buffs;
using Cotd_Logic.Models.Common;

namespace Cotd_Logic.Models.BoardPieces;

public delegate void BoardPieceDestroyedEventHandler(string boardTile);
public abstract class BoardPiece : ITargetable
{
	protected BoardPiece(string name, string image)
	{
		Image = image;
		Name = name;
	}

	public event BoardPieceDestroyedEventHandler? Destroyed;

    public string Id { get; set; }
    public string Image { get; set; }
	public string Name { get; set; }

	protected void OnDestroyed()
	{
		Destroyed?.Invoke(Id);
	}

	public override bool Equals(object? obj)
	{
		if (ReferenceEquals(this, obj)) return true;
		if (obj is not BoardPiece other) return false;

		return Equals(Id, other.Id);
	}

	public override int GetHashCode()
	{
		return Id?.GetHashCode() ?? 0; // Safe null handling
	}
}
