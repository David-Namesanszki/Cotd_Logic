using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories;
using Cotd_Data.Repositories.GameInfoRepositories;

namespace Cotd_Logic.CardPurchase;

public class CardPurchaser
{
	private readonly ICardRepository<CardData> _cardRepo;
	private readonly IGameRepository _gameRepo;

	public void PurchaseCard(int gameId, string cardId)
	{
		CardData cardData = _cardRepo.GetOne(cardId);
		_gameRepo.UnlockCard(gameId, cardData);
	}

}
