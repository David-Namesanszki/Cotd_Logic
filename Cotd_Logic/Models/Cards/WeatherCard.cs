using Cotd_Data.Models;
using Cotd_Data.Models.Cards;
using Cotd_Logic.Dtos.CardDtos;

namespace Cotd_Logic.Models.Cards;

public class WeatherCard : Card
{
	private readonly WeatherCardData _data;

    public WeatherCard()
    {
        _data = new WeatherCardData();
    }

    public WeatherCard(WeatherCardData cardData) : base(cardData)
	{
		_data = cardData;
	}

	public WeatherCardDto ToDto()
	{
		WeatherCardDto dto = new()
		{
			Name = Name,
			Image = Image,
			Description = Description,
			EnvoyCost = EnvoyCost.ToString(),
		};

		return dto;
	}

	public override string ToString()
	{
		return base.ToString();
	}
}
