using Cotd_Data.Models.Cards;

namespace Cotd_Logic.Models.Cards;

public class FireCard : Card
{
    public FireCard()
    {
    }

    public FireCard(FireCardData cardData) : base(cardData)
	{
		FireCost = cardData.FireCost;
	}

	public int FireCost { get; set; }

	public override FireCardData ToData()
	{
		FireCardData data = new()
		{
			Id = Id,
			Name = Name,
			Image = Image,
			Description = Description,
			EnvoyCost = EnvoyCost,
			FireCost = FireCost,
			CardType = (Cotd_Data.Models.Cards.CardTypes)CardType,
		};

		return data;
	}

	public override string ToString()
	{
		return base.ToString() + "\n" +
			$"FireCost: {FireCost}\n";
	}
}
