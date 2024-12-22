using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DamageSystem.DamageBehaviours;

public class SimpleDamageTakeBehaviour
{
	public void TakeDamage(IDamageable damageable, int amount, bool bypassArmor)
	{
		int originalHealth = damageable.Health;

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
