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
	public WeatherCard(WeatherCardData data)
	{
		_data = data;

		Id = _data.Id;
		Name = _data.Name;
		Description = _data.Description;
		Image = _data.Image;
		EnvoyCost = _data.EnvoyCost;
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
}
