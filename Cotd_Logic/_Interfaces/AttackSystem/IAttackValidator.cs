using Cotd_Logic.Models.BoardPieces;

namespace Cotd_Logic._Interfaces.AttackSystem
{
    public interface IAttackValidator
    {
        bool IsValidAttacker(BoardPiece boardPiece);
    }
}