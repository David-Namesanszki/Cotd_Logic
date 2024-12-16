using Cotd_Logic.BL.GameLogic.Behaviours;
using Cotd_Logic.Models.Boards.BoardTiles;

namespace Cotd_Logic._Interfaces.AttackSystem
{
    public interface IAttackTargetFinder
    {
        IDamageable? FindAttackTarget(IAttacker damager);
    }
}