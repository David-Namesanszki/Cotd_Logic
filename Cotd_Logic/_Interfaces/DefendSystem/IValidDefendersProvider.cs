using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.Models.BoardPieces;

namespace Cotd_Logic._Interfaces.DefendSystem
{
    public interface IValidDefendersProvider
    {
        IList<IDefender> GetValidDefenders(IList<BoardPiece> boardPieces);
    }
}