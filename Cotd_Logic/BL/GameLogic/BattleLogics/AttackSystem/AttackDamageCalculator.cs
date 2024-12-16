using Cotd_Logic._Interfaces.AttackSystem;
using Cotd_Logic.BL.GameLogic.Behaviours;
using Cotd_Logic.Models.Buffs;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.AttackSystem;

public class AttackDamageCalculator : IAttackDamageCalculator
{
    public int GetAttackDamage(IAttacker damager)
    {
        int attackDamage = damager.Power;

        if (damager is IBuffable buffable)
        {
            // Aggregate all damage buffs in one step
            attackDamage += buffable.Buffs
                .Where(buff => buff.BuffType == BuffTypes.DamageBuff)
                .Sum(buff => buff.Amount);
        }

        return attackDamage;
    }
}
