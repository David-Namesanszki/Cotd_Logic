using Cotd_Logic.BL.GameLogic.BattleLogics.DamageSystem;
using Cotd_Logic.BL.GameLogic.Behaviours;

namespace Cotd_Logic._Interfaces.DamageSystem
{
    public interface IDamageTakeService
    {
        event DamageTakenEventHandler? DamageTaken;

        void TakeDamage(IDamageable damageable, int damage);
    }
}