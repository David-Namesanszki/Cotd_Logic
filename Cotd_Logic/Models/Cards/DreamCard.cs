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

	public DreamCard(DreamCardData cardData) : base(cardData)
	{
		_data = cardData;
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

	public override string ToString()
	{
		return base.ToString();
	}
}
