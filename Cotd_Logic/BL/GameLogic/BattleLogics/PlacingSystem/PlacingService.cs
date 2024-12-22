using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Services;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.PlacingSystem;

public class BoardPiecePlacedEventArgs : EventArgs
{
	public BoardPiecePlacedEventArgs(IPlacement placement, IPlaceable placeable)
	{
		Placement = placement;
		Placeable = placeable;
	}

	public IPlacement Placement { get; }
	public IPlaceable Placeable { get; }
}

public delegate void BoardPiecePlacedEventHandler(object sender, BoardPiecePlacedEventArgs e);

public class PlacingService : IPlacingService
{
	private readonly IPlacingValidator _validator;

	public PlacingService(IPlacingValidator validator)
	{
		_validator = validator;
	}

	public event EventHandler<BoardPiecePlacedEventArgs>? Placed;

	public void Place(IPlacement placement, IPlaceable placeable)
    {
		if (!_validator.ValidatePlacing(placement, placeable))
			throw new ArgumentException("Placing is invalid");

		placement.Place(placeable);

		OnPlaced(placement, placeable);
	}

	protected virtual void OnPlaced(IPlacement placement, IPlaceable placeable)
	{
		Placed?.Invoke(this, new BoardPiecePlacedEventArgs(placement, placeable));
	}
}
