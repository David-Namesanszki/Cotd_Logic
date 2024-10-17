using Cotd_Data.Models.Cards;
using Cotd_Logic.Dtos.CardDtos;

namespace Cotd_Logic.Models.Cards;

public class ConstructionCard : Card
{
	private readonly ConstructionCardData _data;

	public ConstructionCard()
	{
		_data = new ConstructionCardData();
	}
	public ConstructionCard(ConstructionCardData data)
	{
		_data = data;

		Id = _data.Id;
		Name = _data.Name;
		Description = _data.Description;
		Image = _data.Image;
		EnvoyCost = _data.EnvoyCost;
		Armor = _data.Armor;
		Power = _data.Power;
		TurnsToBuild = _data.TurnsToBuild;
	}

	public int Armor { get; set; }
	public int Power { get; set; }
	public int TurnsToBuild { get; set; }


	public ConstructionCardDto ToDto()
	{
		ConstructionCardDto dto = new()
		{
			Name = Name,
			Image = Image,
			Description = Description,
			EnvoyCost = EnvoyCost.ToString(),
			Armor = Armor.ToString(),
			Power = Power.ToString(),
			TurnsToBuild = TurnsToBuild.ToString(),
		};

		return dto;
	}
}
