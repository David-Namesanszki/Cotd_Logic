using Cotd_Logic.BL.GameLogic.Behaviours;

namespace Cotd_Logic._Interfaces.AttackSystem
{
	public interface IAttackService
    {
        void AttackWith(IAttacker damager);
    }
}