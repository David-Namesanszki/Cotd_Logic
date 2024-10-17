using Cotd_Data.Models.Cards;
using Cotd_Logic.Dtos.CardDtos;

namespace Cotd_Logic.Models.Cards;

public class DreamCard : Card
{
	private readonly DreamCardData _data;

	public DreamCard()
	{
		_data = new DreamCardData();
	}
	public DreamCard(DreamCardData data)
	{
		_data = data;

		Id = _data.Id;
		Name = _data.Name;
		Description = _data.Description;
		Image = _data.Image;
		EnvoyCost = _data.EnvoyCost;
	}

	public DreamCardDto ToDto()
	{
		DreamCardDto dto = new()
		{
			Name = Name,
			Image = Image,
			Description = Description,
			EnvoyCost = EnvoyCost.ToString()
		};

		return dto;
	}
}
