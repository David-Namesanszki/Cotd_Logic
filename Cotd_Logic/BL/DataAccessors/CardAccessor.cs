using Cotd_Data._Interfaces;
using Cotd_Data.Models.Cards;
using Cotd_Logic._Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.BL.DataAccessors;

public class CardAccessor : IDataAccessor<Card>
{
    private readonly ICardRepository _repo;

    public CardAccessor(ICardRepository repo)
    {
        _repo = repo;
    }

    public List<Card> GetAll()
    {
        return _repo.GetAll().Select(CreateCard).ToList();
    }

    public Card GetOne(string id)
    {
        return CreateCard(_repo.GetOne(id));
    }

    private Card CreateCard(CardData cardData)
    {
        return cardData.CardType switch
        {
            Cotd_Data.Models.Cards.CardTypes.CommandCard => new CommandCard(cardData as CommandCardData ?? throw new InvalidCastException("Invalid CommandCardData")),
            Cotd_Data.Models.Cards.CardTypes.ConstructionCard => new ConstructionCard(cardData as ConstructionCardData ?? throw new InvalidCastException("Invalid ConstructionCardData")),
            Cotd_Data.Models.Cards.CardTypes.DreamCard => new DreamCard(cardData as DreamCardData ?? throw new InvalidCastException("Invalid DreamCardData")),
            Cotd_Data.Models.Cards.CardTypes.FireCard => new FireCard(cardData as FireCardData ?? throw new InvalidCastException("Invalid FireCardData")),
            Cotd_Data.Models.Cards.CardTypes.UnitCard => new UnitCard(cardData as UnitCardData ?? throw new InvalidCastException("Invalid UnitCardData")),
            Cotd_Data.Models.Cards.CardTypes.WeatherCard => new WeatherCard(cardData as WeatherCardData ?? throw new InvalidCastException("Invalid WeatherCardData")),
            Cotd_Data.Models.Cards.CardTypes.Undefined => throw new ArgumentException("Card type is undefined"),
            _ => throw new ArgumentException("Card type is unknown")
        };
    }
}
