using Cotd_Logic.BL.GameLogic.Behaviours;
using Cotd_Logic.Models.BoardPieces;

namespace Cotd_Logic._Interfaces.HealingSystem
{
    public interface IValidHealablesProvider
    {
        IList<IHealable> GetValidHealables(IList<BoardPiece> boardPieces);
    }
}