using Cotd_Data.Models;
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

    public FireCard(FireCardData cardData) : base(cardData)
	{
		_data = cardData;
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

	public override string ToString()
	{
		return base.ToString() + "\n" +
			$"FireCost: {FireCost}\n";
	}
}
