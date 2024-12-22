using Cotd_Logic._Interfaces.AttackSystem;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Services;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.AttackSystem;

public class AttackEventArgs
{
	public AttackEventArgs(IAttacker attacker)
	{
		Attacker = attacker;
	}

	public IAttacker Attacker { get; set; }
}
public class AttackService : IAttackService
{
    private readonly IAttackTargetFinder _targetFinder;
    private readonly IAttackDamageCalculator _damageCalculator;
    private readonly ITakeDamageService _damageTakeService;
    private readonly IAttackValidator _attackValidator;

    public event EventHandler<AttackEventArgs>? Attacked;

    public AttackService(IAttackTargetFinder targetFinder, IAttackDamageCalculator damageCalculator, ITakeDamageService damageTakeService)
    {
        _targetFinder = targetFinder;
        _damageCalculator = damageCalculator;
        _damageTakeService = damageTakeService;
    }

    public void AttackWith(IAttacker attacker)
    {
        if (!_attackValidator.IsValidAttacker(attacker))
            throw new ArgumentException("Attacker is not valid");

		IDamageable? target = _targetFinder.FindAttackTarget(attacker);
        int attackDamage = _damageCalculator.GetAttackDamage(attacker);

        if (target != null)
        {
			_damageTakeService.TakeDamage(target, attackDamage);

			OnAttacked(attacker);
        }
    }

    protected virtual void OnAttacked(IAttacker attacker)
    {
        Attacked?.Invoke(this, new AttackEventArgs(attacker));
    }
}
