using Cotd_Data.Models;
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

    public ConstructionCard(ConstructionCardData cardData) : base(cardData)
	{
		_data = cardData;
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

	public override string ToString()
	{
		return base.ToString() + "\n" +
			$"Armor: {Armor}\n" +
			$"Power: {Power}\n" +
			$"TurnsToBuild: {TurnsToBuild}\n";
	}
}
