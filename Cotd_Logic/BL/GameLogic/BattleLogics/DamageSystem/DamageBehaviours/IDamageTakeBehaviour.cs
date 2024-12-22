using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DamageSystem.DamageBehaviours;

public interface IDamageTakeBehaviour
{
	void TakeDamage(IDamageable damageable, int amount, bool byPassArmor);
}
