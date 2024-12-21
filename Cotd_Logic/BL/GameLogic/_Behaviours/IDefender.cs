using Cotd_Logic.BL.GameLogic._Behaviours;

namespace Cotd_Logic.BL.GameLogic.Behaviours;

public interface IDefender : ITargetable
{
    int DefenseValue { get; set; }
    int CurrentArmor { get; }
    bool CanDefend { get; set; }
    void IncreaseArmor(int amount);
	void DecreaseArmor(int amount);
}
