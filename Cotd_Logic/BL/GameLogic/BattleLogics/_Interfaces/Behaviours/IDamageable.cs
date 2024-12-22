namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

public interface IDamageable
{
    /// <summary>
    /// Gets the entity's armor value.
    /// </summary>
    int Armor { get; }

    /// <summary>
    /// Gets the current health of the entity.
    /// </summary>
    int Health { get; }

    /// <summary>
    /// Determines whether the entity can be damaged.
    /// </summary>
    bool CanBeDamaged { get; }

    /// <summary>
    /// Apply damage to the entity, adjusting health and armor accordingly.
    /// </summary>
    void TakeDamage(int amount, bool bypassArmor = false);
}
