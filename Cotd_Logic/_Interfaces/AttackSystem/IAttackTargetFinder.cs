using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

namespace Cotd_Logic._Interfaces.AttackSystem
{
    public interface IAttackTargetFinder
    {
        IDamageable? FindAttackTarget(IAttacker damager);
    }
}