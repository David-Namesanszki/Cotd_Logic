namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

public interface IDefender : ITargetable
{
	/// <summary>
	/// Gets the base defense value of the entity, used to reduce incoming damage.
	/// </summary>
	int DefenseValue { get; }

	/// <summary>
	/// Gets the current armor value of the entity, which absorbs damage.
	/// </summary>
	int CurrentArmor { get; }

	public bool CanDefend { get; }

	/// <summary>
	/// Increases the current armor of the entity by a fixed or calculated amount.
	/// </summary>
	void IncreaseArmor(int amount);
	void Defend();
}
