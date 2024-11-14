using Cotd_Data.Models.Cards;
using Cotd_Data.Models.Enemies;
using Cotd_Data.Models.Games.Decks;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.Models.Games.Decks;

public class Deck
{

    public Deck()
    {
    }
    public Deck(DeckData deckData)
    {
		Id = deckData.Id;
		Cards = deckData.Cards.Select(CreateCard).ToList();
	}

	public string Id { get; set; } = Guid.NewGuid().ToString();
	public List<Card> Cards { get; set; } = [];

	public DeckData ToData()
	{
		return new DeckData()
		{
			Id = Id,
			Cards = Cards.Select(c => c.ToData()).ToList(),
		};
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
