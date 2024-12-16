using Cotd_Data.Models.Cards;

namespace Cotd_Logic.Models.Cards;

public class DreamCard : Card
{
	public DreamCard()
	{
	}

	public DreamCard(DreamCardData cardData) : base(cardData)
	{
	}

	public override DreamCardData ToData()
	{
		DreamCardData data = new()
		{
			Id = Id,
			Name = Name,
			Image = Image,
			Description = Description,
			EnvoyCost = EnvoyCost,
			CardType = (Cotd_Data.Models.Cards.CardTypes)CardType,
			Effects = Effects.Select(x => x.ToData()).ToList()
		};

		return data;
	}

	public override string ToString()
	{
		return base.ToString();
	}
}
