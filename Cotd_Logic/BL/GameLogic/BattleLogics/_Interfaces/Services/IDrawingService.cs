using Cotd_Logic.BL.GameLogic.BattleLogics.DefendSystem;
using Cotd_Logic.BL.GameLogic.BattleLogics.DrawingSystem;

namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Services
{
    public interface IDrawingService
    {
		event Action? DiscardPileTransferred;
        event Action? HandIsFull;
        event CardDrawnEventHandler? CardDrawn;
        void DrawMultipleCards(int amount);
        void DrawSingleCard();
    }
}