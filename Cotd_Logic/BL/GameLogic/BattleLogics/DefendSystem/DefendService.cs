using Cotd_Logic.BL.Common;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Services;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators;
using Cotd_Logic.BL.GameLogic.BattleLogics.DamageSystem;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DefendSystem;

public class DefendedEventArgs : EventArgs
{
	public IDefender Defender { get; }

	public DefendedEventArgs(IDefender defender)
	{
		Defender = defender;
	}
}

public class DefendService : IDefendService
{
	private readonly IDefendValidator _validator;

	public DefendService(IDefendValidator validator)
	{
		_validator = validator;
	}

	public event EventHandler<DefendedEventArgs>? Defended;

	public void ApplyDefense(IDefender defender)
	{
		if (!defender.CanDefend)
			throw new ArgumentException("");

		defender.Defend();

		OnDefended(defender);
	}

	protected virtual void OnDefended(IDefender defender)
	{
		Defended?.Invoke(this, new DefendedEventArgs(defender));
	}
}
