using Cotd_Logic.BL.GameLogic.BattleLogics.DefendSystem;
using Cotd_Logic.BL.GameLogic.Behaviours;

namespace Cotd_Logic._Interfaces.DefendSystem
{
    public interface IDefendService
    {
        event DefendedEventHandler? Defended;

        void DefendWith(IDefender defender);
    }
}