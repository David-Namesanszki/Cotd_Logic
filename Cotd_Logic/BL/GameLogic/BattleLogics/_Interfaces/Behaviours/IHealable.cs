namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

public interface IHealable
{
    /// <summary>
    /// Gets the maximum health of the entity.
    /// </summary>
    int MaxHealth { get; }

    /// <summary>
    /// Gets the current health of the entity.
    /// </summary>
    int CurrentHealth { get; }

    /// <summary>
    /// Determines whether the entity can be healed.
    /// </summary>
    bool CanBeHealed { get; }

    /// <summary>
    /// Apply healing to the entity, increasing health but not exceeding max health.
    /// </summary>
    void Heal(int amount);
}
