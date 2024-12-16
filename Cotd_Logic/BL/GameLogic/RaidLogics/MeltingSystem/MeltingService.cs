using Cotd_Logic.Models;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.BL.GameLogic.RaidLogics.MeltingSystem;

public class MeltingService
{
    private Raid _raid;
    public void MeltCard(Card card)
    {
        _raid.Deck.Remove(card);
        _raid.FireAmount += 20;
    }
}
