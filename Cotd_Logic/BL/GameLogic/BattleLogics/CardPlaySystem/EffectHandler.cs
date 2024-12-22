using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Services;
using Cotd_Logic.Models.Effects;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.CardPlaySystem;

public class EffectHandler : IEffectHandler
{
    private readonly IDrawingService _drawService;
    private readonly IDefendService _defendService;
    private readonly IAttackService _attackService;
    private readonly IHealingService _healingService;

    public EffectHandler(IDrawingService drawService, IDefendService defendService,
                         IAttackService attackService, IHealingService healingService)
    {
        _drawService = drawService ?? throw new ArgumentNullException(nameof(drawService));
        _defendService = defendService ?? throw new ArgumentNullException(nameof(defendService));
        _attackService = attackService ?? throw new ArgumentNullException(nameof(attackService));
        _healingService = healingService ?? throw new ArgumentNullException(nameof(healingService));
    }

    /// <summary>
    /// Handles the specified effect type by invoking the appropriate service.
    /// </summary>
    /// <param name="effectType">The type of effect to handle.</param>
    /// <param name="parameter">An integer parameter associated with the effect (e.g., amount of cards to draw).</param>
    /// <param name="target">The target object of the effect (optional for some effects).</param>
    /// <exception cref="ArgumentException">Thrown when the target is not of the expected type.</exception>
    public void HandleEffect(Effect effect, ITargetable? target)
    {
        switch (effect.EffectType)
        {
            case EffectTypes.DrawCard:
                if (effect.Parameter is int drawParameter)
                    _drawService.DrawMultipleCards(drawParameter);
                break;
            case EffectTypes.DealDamage:
                if (target is not IAttacker attacker)
                    throw new ArgumentException("Target must implement IAttacker for DealDamage effect.");
                _attackService.AttackWith(attacker);
                break;
            case EffectTypes.ArmorUp:
                if (target is not IDefender defender)
                    throw new ArgumentException("Target must implement IDefender for ArmorUp effect.");
                _defendService.ApplyDefense(defender);
                break;
            case EffectTypes.Heal:
                if (target is not IHealable healable)
                    throw new ArgumentException("Target must implement IHealable for Heal effect.");
                if (effect.Parameter is int healParameter)
                    _healingService.Heal(healable, healParameter);
                break;
            default:
                throw new NotSupportedException($"Effect type {effect.EffectType} is not supported.");
        }
    }
}