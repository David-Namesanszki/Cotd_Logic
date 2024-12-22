using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

namespace Cotd_Logic.Models.BoardPieces;

public abstract class BoardPiece : ITargetable
{
	protected BoardPiece(string name, string image)
	{
		Id = Guid.NewGuid().ToString();
		Image = image ?? throw new ArgumentNullException(nameof(image));
		Name = name ?? throw new ArgumentNullException(nameof(name));
	}

	public event EventHandler<BoardPieceDestroyedEventArgs>? Destroyed;
	

	public string Id { get; set; }
    public string Image { get; set; }
	public string Name { get; set; }

	protected virtual void OnDestroyed(string boardTile)
	{
		Destroyed?.Invoke(this, new BoardPieceEventArgs(boardTile, Id));
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
