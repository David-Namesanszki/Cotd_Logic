using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DamageSystem;

public class TakeDamageValidator : ITakeDamageValidator
{
	public bool ValidateDamageTake(IDamageable damageable, int damage)
	{
		return damage >= 0 && damageable.CanBeDamaged;
	}
}
//int originalHealth = damageable.Health;

//if (bypassArmor)
//{
//}
//else
//{
//	// Apply damage reduction based on armor
//	int damageAfterArmor = Math.Max(0, damage - damageable.Armor);
//	damageable.Armor = Math.Max(0, damageable.Armor - damage); // Update armor
//	damageable.Health = Math.Max(0, damageable.Health - damageAfterArmor);
//}
