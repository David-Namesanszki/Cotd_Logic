using Cotd_Data._Interfaces;
using Cotd_Data.Models.Cards;
using Cotd_Data.Models.GameInfos;
using Cotd_Logic.Models.Games.Resources;

namespace Cotd_Logic.BL.PurchasingSystem;

public class CardPurchaser
{
    private readonly IGameRepository _gameRepo;
    private readonly ICardRepository _cardRepo;
    private readonly Random _random;

    public CardData PurchaseRandomCard(string gameId, CardTypes cardType)
    {
        IList<string> allDreamCards = _cardRepo.GetAll().Where(c => c.CardType == cardType).Select(c => c.Id).ToList();
        IList<string> ownedCards = _gameRepo.GetOne(gameId).UnlockedCardIds;

        IList<string> notOwnedCards = allDreamCards.Except(ownedCards).ToList();

        int randomIdx = _random.Next(notOwnedCards.Count);

        string randomCardId = notOwnedCards[randomIdx];

        return _cardRepo.GetOne(randomCardId);
    }

    public void PurchaseCard(string gameId, string cardId)
    {
        GameData gameData = _gameRepo.GetOne(gameId);
        gameData.UnlockedCardIds.Add(cardId);

        _gameRepo.Update(gameData);
    }

    private bool HasResources(Resource resources, Resource cardCost)
    {
        return true;
    }
}
