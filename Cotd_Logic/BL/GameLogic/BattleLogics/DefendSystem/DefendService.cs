using Cotd_Logic._Interfaces.DefendSystem;
using Cotd_Logic.BL.GameLogic.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.DefendSystem;

public delegate void DefendedEventHandler();
public class DefendService : IDefendService
{
    public event DefendedEventHandler? Defended;
    public void DefendWith(IDefender defender)
    {
        defender.CurrentArmor += defender.ArmorUp;

        Defended?.Invoke();
    }
}
