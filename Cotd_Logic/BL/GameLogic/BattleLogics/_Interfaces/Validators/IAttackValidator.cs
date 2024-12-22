using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators
{
    public interface IAttackValidator
    {
        bool IsValidAttacker(IAttacker attacker);
    }
}