using Cotd_Data.Models.Cards;
using Cotd_Logic.Models.Buffs;
using Cotd_Logic.Models.Common;
using Cotd_Logic.Models.Effects;

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

public abstract class Card : Entity
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
		Effects = cardData.Effects.Select(x => new Effect(x)).ToList();
	}

	protected Card(string name, string description, string image, int envoyCost)
	{
		Name = name;
		Description = description;
		Image = image;
		EnvoyCost = envoyCost;
	}

    public CardTypes CardType { get; set; } = CardTypes.Undefined;
	public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
	public string Image { get; set; } = string.Empty;
	public int EnvoyCost { get; set; } = 0;
	public IList<Effect> Effects { get; set; } = [];
	public IList<Buff> Buffs { get; set; } = [];

    public abstract CardData ToData();

	public void AddEffect(Effect effect)
	{
		Effects.Add(effect);
	}
}
