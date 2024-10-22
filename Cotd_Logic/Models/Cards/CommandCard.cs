using Cotd_Data.Models;
using Cotd_Data.Models.Cards;
using Cotd_Logic.Dtos.CardDtos;

namespace Cotd_Logic.Models.Cards;

public class CommandCard : Card
{
	private readonly CommandCardData _data;

    public CommandCard()
    {
        _data = new CommandCardData();
    }

    public CommandCard(CommandCardData cardData) : base(cardData)
	{
		_data = cardData;
	}

	public CommandCardDto ToDto()
	{
		CommandCardDto dto = new()
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
