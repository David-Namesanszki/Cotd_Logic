using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DamageSystem;

public class SimpleDamageTake : IDamageable
{
	public int Armor { get; private set; }

	public int Health { get; private set; }

	public bool CanBeDamaged { get; }

	public void TakeDamage(int amount, bool bypassArmor)
	{
		int originalHealth = Health;

		if (bypassArmor)
		{
			Health = Math.Max(0, Health - amount);
		}
		else
		{
			// Apply damage reduction based on armor
			int damageAfterArmor = Math.Max(0, amount - Armor);
			Armor = Math.Max(0, Armor - amount); // Update armor
			Health = Math.Max(0, Health - damageAfterArmor);
		}
	}
}
