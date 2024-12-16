using Cotd_Logic.BL.GameLogic.Behaviours;

namespace Cotd_Logic._Interfaces.AttackSystem
{
    public interface IAttackDamageCalculator
    {
        int GetAttackDamage(IAttacker damager);
    }
}