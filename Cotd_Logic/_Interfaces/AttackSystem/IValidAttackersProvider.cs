using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.Models.BoardPieces;

namespace Cotd_Logic._Interfaces.AttackSystem
{
    public interface IValidAttackersProvider
    {
        IList<IAttacker> GetValidAttackers(IList<BoardPiece> boardPieces);
    }
}