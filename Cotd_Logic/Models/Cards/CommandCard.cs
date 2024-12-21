using Cotd_Data.Models.Cards;

namespace Cotd_Logic.Models.Cards;

public class CommandCard : Card
{
    public CommandCard()
    {
    }

    public CommandCard(string name, string description, string image, int envoyCost)
		: base(name, description, image, envoyCost)
    {
		CardType = CardTypes.CommandCard;
	}

    public CommandCard(CommandCardData cardData) : base(cardData)
	{
		CardType = CardTypes.CommandCard;
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
			CardType = Cotd_Data.Models.Cards.CardTypes.CommandCard,
			Effects = Effects.Select(x => x.ToData()).ToList()
		};

		return data;
	}

	public override string ToString()
	{
		return base.ToString();
	}
}
