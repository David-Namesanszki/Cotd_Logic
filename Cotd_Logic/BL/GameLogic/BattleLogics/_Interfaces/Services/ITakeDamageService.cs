using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics.DamageSystem;

namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Services
{
    public interface ITakeDamageService
    {
		event EventHandler<DamageTakenEventArgs>? DamageTaken;
		event EventHandler<DiedEventArgs>? Died;

		void TakeDamage(IDamageable damageable, int damage);
    }
}