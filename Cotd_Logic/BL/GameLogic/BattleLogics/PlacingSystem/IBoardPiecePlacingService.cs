using Cotd_Logic.Models.BoardTiles;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.PlacingSystem
{
    public interface IBoardPiecePlacingService
    {
        void PlaceBoardPiece(Card card, BoardTile boardTile);
    }
}