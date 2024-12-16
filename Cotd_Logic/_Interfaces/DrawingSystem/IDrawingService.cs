using Cotd_Logic.BL.GameLogic.BattleLogics.DrawingSystem;

namespace Cotd_Logic._Interfaces.DrawingSystem
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