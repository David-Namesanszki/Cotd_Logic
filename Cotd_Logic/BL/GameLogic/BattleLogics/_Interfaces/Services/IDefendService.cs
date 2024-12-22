using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics.DefendSystem;

namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Services
{
    public interface IDefendService
    {
		event EventHandler<DefendedEventArgs>? Defended;

		void ApplyDefense(IDefendBehaviour defendBehaviour, IDefender defender);
    }
}