using Cotd_Data.Models.Cards;

namespace Cotd_Logic.Models.Cards;

public class WeatherCard : Card
{
    public WeatherCard()
    {
    }

    public WeatherCard(WeatherCardData cardData) : base(cardData)
	{
	}

	public override WeatherCardData ToData()
	{
		WeatherCardData data = new()
		{
			Id = Id,
			Name = Name,
			Image = Image,
			Description = Description,
			EnvoyCost = EnvoyCost,
			CardType = (Cotd_Data.Models.Cards.CardTypes)CardType,
		};

		return data;
	}

	public override string ToString()
	{
		return base.ToString();
	}
}
