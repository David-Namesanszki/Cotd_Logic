using Cotd_Logic._Interfaces.HealSystem;
using Cotd_Logic.BL.GameLogic.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.HealingSystem;

public delegate void HealedEventService(IHealable healable, int amount);
public class HealingService : IHealingService
{
    public event HealedEventService? Healed;
    public void Heal(IHealable healable, int amount)
    {
        healable.Health += amount;

        Healed?.Invoke(healable, amount);
    }
}
