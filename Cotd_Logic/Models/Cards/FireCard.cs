using Cotd_Data.Models.Cards;
using Cotd_Logic.Dtos.CardDtos;

namespace Cotd_Logic.Models.Cards;

public class FireCard : Card
{
	private readonly FireCardData _data;

	public FireCard()
	{
		_data = new FireCardData();
	}
	public FireCard(FireCardData data)
	{
		_data = data;

		Id = _data.Id;
		Name = _data.Name;
		Description = _data.Description;
		Image = _data.Image;
		EnvoyCost = _data.EnvoyCost;
		FireCost = _data.FireCost;
	}

	public int FireCost { get; set; }

	public FireCardDto ToDto()
	{
		FireCardDto dto = new()
		{
			Name = Name,
			Image = Image,
			Description = Description,
			EnvoyCost = EnvoyCost.ToString(),
			FireCost = FireCost.ToString()
		};

		return dto;
	}
}
