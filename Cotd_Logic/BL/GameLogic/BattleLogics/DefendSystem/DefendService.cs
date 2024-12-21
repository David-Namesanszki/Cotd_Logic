using Cotd_Logic._Interfaces.DefendSystem;
using Cotd_Logic.BL.GameLogic.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DefendSystem;

public delegate void DefendedEventHandler(object sender, DefendedEventArgs e);

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
    public event DefendedEventHandler? Defended;
	public void ApplyDefense(IDefender defender)
	{
		if (!defender.CanDefend)
		{
			throw new InvalidOperationException("The defender cannot defend.");
		}

		defender.IncreaseArmor(defender.DefenseValue);

		OnDefended(new DefendedEventArgs(defender));
	}

	protected virtual void OnDefended(DefendedEventArgs e)
	{
		Defended?.Invoke(this, e);
	}
}
