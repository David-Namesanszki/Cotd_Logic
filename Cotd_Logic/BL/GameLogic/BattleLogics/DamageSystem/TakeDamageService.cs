using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DamageSystem;

public class DamageTakenEventArgs : EventArgs
{
	public IDamageable Damageable { get; }
	public int Amount { get; }

	public DamageTakenEventArgs(IDamageable damageable, int amount)
	{
		Damageable = damageable;
		Amount = amount;
	}
}

public class DiedEventArgs : EventArgs
{
	public IDamageable Damageable { get; }

	public DiedEventArgs(IDamageable damageable)
	{
		Damageable = damageable;
	}
}

public class ArmorBrokenEventArgs : EventArgs
{
	public IDamageable Damageable { get; }

	public ArmorBrokenEventArgs(IDamageable damageable)
	{
		Damageable = damageable;
	}
}

public class TakeDamageService
{
	private readonly ITakeDamageValidator _validator;

	public TakeDamageService(ITakeDamageValidator validator)
	{
		_validator = validator;
	}

	public event EventHandler<DamageTakenEventArgs>? DamageTaken;
	public event EventHandler<DiedEventArgs>? Died;
	public event EventHandler<ArmorBrokenEventArgs>? ArmorBroken;

	public void TakeDamage(IDamageable damageable, int damage, bool bypassArmor = false)
	{
		if (!_validator.ValidateDamageTake(damageable, damage))
			throw new ArgumentException("Damage take is invalid");

		damageable.TakeDamage(damage);

		OnDamageTaken(damageable, damage);

		if(damageable.Armor == 0)
		{
			OnArmorBroken(damageable);
		}

		if (damageable.Health == 0)
		{
			OnDied(damageable);
		}
	}

	protected virtual void OnDamageTaken(IDamageable damageable, int damage)
	{
		DamageTaken?.Invoke(this, new DamageTakenEventArgs(damageable, damage));
	}

	protected virtual void OnArmorBroken(IDamageable damageable)
	{
		ArmorBroken?.Invoke(this, new ArmorBrokenEventArgs(damageable));
	}

	protected virtual void OnDied(IDamageable damageable)
	{
		Died?.Invoke(this, new DiedEventArgs(damageable));
	}
}
