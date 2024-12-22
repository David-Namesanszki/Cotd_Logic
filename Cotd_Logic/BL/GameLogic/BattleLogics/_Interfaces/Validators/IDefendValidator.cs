using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators
{
    public interface IDefendValidator
    {
        bool ValidateDefend(IDefender defender);
    }
}