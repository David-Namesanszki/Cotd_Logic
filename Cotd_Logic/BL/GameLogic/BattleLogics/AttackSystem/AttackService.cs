using Cotd_Logic._Interfaces.AttackSystem;
using Cotd_Logic._Interfaces.DamageSystem;
using Cotd_Logic.BL.GameLogic.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.AttackSystem;

public delegate void AttackedEventHandler(IDamageable target, int attackDamage);
public class AttackService : IAttackService
{
    private readonly IAttackTargetFinder _targetFinder;
    private readonly IAttackDamageCalculator _damageCalculator;
    private readonly IDamageTakeService _damageTakeService;

    public event AttackedEventHandler? Attacked;

    public AttackService(IAttackTargetFinder targetFinder, IAttackDamageCalculator damageCalculator, IDamageTakeService damageTakeService)
    {
        _targetFinder = targetFinder;
        _damageCalculator = damageCalculator;
        _damageTakeService = damageTakeService;
    }

    public void AttackWith(IAttacker attacker)
    {
        IDamageable? target = _targetFinder.FindAttackTarget(attacker);
        int attackDamage = _damageCalculator.GetAttackDamage(attacker);

        if (target != null)
        {
            target.TakeDamage(attackDamage);

			Attacked?.Invoke(target, attackDamage);
        }
    }
}
