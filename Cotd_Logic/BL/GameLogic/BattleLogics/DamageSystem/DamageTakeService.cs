using Cotd_Logic._Interfaces.DamageSystem;
using Cotd_Logic.BL.GameLogic.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DamageSystem;

public delegate void DamageTakenEventHandler(IDamageable target, int attackDamage);
public class DamageTakeService : IDamageTakeService
{
    public event DamageTakenEventHandler? DamageTaken;
    public void TakeDamage(IDamageable damageable, int damage)
    {
        damageable.HitPoints -= damage;

        DamageTaken?.Invoke(damageable, damage);
    }
}
