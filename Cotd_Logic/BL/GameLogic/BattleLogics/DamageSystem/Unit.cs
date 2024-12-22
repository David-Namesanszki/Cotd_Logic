using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics.AttackSystem.AttackBehaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics.DefendSystem.DefendBehaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DamageSystem;

public class Unit : IDefender
{
	IDefendBehaviour _defendBehaviour;
	IAttackBehaviour _attackBehaviour;

	public int DefenseValue { get; }

	public int CurrentArmor { get; private set; }

	public bool CanDefend { get; }

	public string Id { get; set; }

	public void IncreaseArmor(int amount)
	{
		CurrentArmor += amount;
	}

	public void Defend()
	{
		_defendBehaviour.DefendWith(this);
	}

	public void TakeDamage()
	{

	}
}

public class UnitFactory
{
	IDefendBehaviour defendBehaviour = new SimpleDefendBehaviour();

    public UnitFactory()
    {
		Unit unit1 = new Unit(defendBehaviour);
	}
}