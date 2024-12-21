using Cotd_Logic.BL.GameLogic._Behaviours;
using Cotd_Logic.Models.BoardPieces;
using Cotd_Logic.Models.BoardTiles;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.PlacingSystem;

public class PlacingService : IPlacingService
{
    public void PlaceBoardPiece(BoardPiece boardPiece, PlacementBoardTile placementTile)
    {
		placementTile.BoardPiece = boardPiece;
	}
}
