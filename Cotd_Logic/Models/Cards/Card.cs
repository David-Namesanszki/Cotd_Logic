using Cotd_Data.Models.Cards;

namespace Cotd_Logic.Models.Cards;

public enum CardTypes
{
	CommandCard,
	ConstructionCard,
	DreamCard,
	FireCard,
	UnitCard,
	WeatherCard,
	Undefined,
}

public abstract class Card
{
	protected Card()
	{
	}

	protected Card(CardData cardData)
	{
		Id = cardData.Id;
		Name = cardData.Name;
		Description = cardData.Description;
		Image = cardData.Image;
		CardType = (CardTypes)cardData.CardType;
		EnvoyCost = cardData.EnvoyCost;
	}

	public string Id { get; set; } = Guid.NewGuid().ToString();
    public CardTypes CardType { get; set; } = CardTypes.Undefined;
	public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
	public string Image { get; set; } = string.Empty;
	public int EnvoyCost { get; set; } = 0;

	public abstract CardData ToData();

	public override string ToString()
	{
		return $"Card: {Name}\n" +
			   $"Id: {Id}\n" +
			   $"Description: {Description}\n" +
			   $"Image: {Image}\n" +
			   $"EnvoyCost: {EnvoyCost}\n";
	}
}
