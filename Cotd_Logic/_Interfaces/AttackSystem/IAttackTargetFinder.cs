using Cotd_Logic.BL.GameLogic.Behaviours;

namespace Cotd_Logic._Interfaces.AttackSystem
{
	public interface IAttackTargetFinder
    {
        IDamageable? FindAttackTarget(IAttacker damager);
    }
}