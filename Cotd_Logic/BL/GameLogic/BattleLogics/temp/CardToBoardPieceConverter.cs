using Cotd_Logic.Models.BoardPieces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.temp;

public class CardToBoardPieceConverter
{
    public BoardPiece ConvertToBoardPiece(Card card)
    {
        if (card is UnitCard unitCard)
        {
            return new Unit();
        }
        else if (card is ConstructionCard constructionCard)
        {
            return new Construction();
        }
        else
        {
            throw new ArgumentException();
        }
    }
}
