using Cotd_Logic.Models;
using Cotd_Logic.Models.Boards.BoardPieces;
using Cotd_Logic.Models.BoardTiles;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.PlacingSystem;

public class BoardPiecePlacingService : IBoardPiecePlacingService
{
    Board _board;

    public void PlaceBoardPiece(Card card, BoardTile boardTile)
    {
        if (card is UnitCard unitCard)
        {
            _board.BlueBoardPieces.Add(new Unit(unitCard));
        }
        else if (card is ConstructionCard constructionCard)
        {
            _board.BlueBoardPieces.Add(new Construction(constructionCard));
        }
        else
        {
            throw new ArgumentException($"Card type: {card.GetType()} is unknown");
        }
    }
}
