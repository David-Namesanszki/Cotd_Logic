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
    public CommandCard(CommandCardData data)
    {
		_data = data;

		Id = _data.Id;
		Name = _data.Name;
		Description = _data.Description;
		Image = _data.Image;
		EnvoyCost = _data.EnvoyCost;
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
}
