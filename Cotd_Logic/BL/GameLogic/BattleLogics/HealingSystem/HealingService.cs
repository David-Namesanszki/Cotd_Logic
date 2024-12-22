using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Services;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.HealingSystem;

public class HealedEventArgs : EventArgs
{
	public HealedEventArgs(IHealable healable, int amount)
	{
		Healable = healable;
		Amount = amount;
	}

	public IHealable Healable { get; }
	public int Amount { get; }
}

public class HealingService : IHealingService
{
	private readonly IHealingValidator _validator;

	public HealingService(IHealingValidator validator)
	{
		_validator = validator;
	}

	public event EventHandler<HealedEventArgs>? Healed;
	public void Heal(IHealable healable, int amount)
	{
		_validator.ValidateHealing(healable, amount);

		healable.Heal(amount);

		OnHealed(healable, amount);
	}

	protected virtual void OnHealed(IHealable healable, int amount)
	{
		Healed?.Invoke(this, new HealedEventArgs(healable, amount));
	}
}
