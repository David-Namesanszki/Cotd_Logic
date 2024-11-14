using Cotd_Data.Models.Cards;

namespace Cotd_Logic.Models.Cards;

public class CommandCard : Card
{
    public CommandCard(CommandCardData cardData) : base(cardData)
	{
	}

	public override CommandCardData ToData()
	{
		CommandCardData data = new()
		{
			Id = Id,
			Name = Name,
			Image = Image,
			Description = Description,
			EnvoyCost = EnvoyCost,
			CardType = (Cotd_Data.Models.Cards.CardTypes)CardType
		};

		return data;
	}

	public override string ToString()
	{
		return base.ToString();
	}
}
