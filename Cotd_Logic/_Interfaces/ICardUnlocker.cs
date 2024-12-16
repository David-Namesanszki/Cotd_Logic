using Cotd_Logic.Models.Cards;

namespace Cotd_Logic._Interfaces
{
    public interface ICardUnlocker
    {
        Card UnlockRandomCard(CardTypes cardType);
    }
}