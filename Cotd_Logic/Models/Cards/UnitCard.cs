using Cotd_Data.Models.Cards;
using Cotd_Logic.Dtos.CardDtos;

namespace Cotd_Logic.Models.Cards;

public enum UnitTypes
{
    Melee,
    Ranged,
    Support
}

public class UnitCard : Card
{
	private readonly UnitCardData _data;

	public UnitCard()
	{
		_data = new UnitCardData();
	}
	public UnitCard(UnitCardData data)
	{
		_data = data;

		Id = _data.Id;
		Name = _data.Name;
		Description = _data.Description;
		Image = _data.Image;
		EnvoyCost = _data.EnvoyCost;
		TurnsToFormation = _data.TurnsToFormation;
		Health = _data.Health;
		Power = _data.Power;
		Armor = _data.Armor;
		Type = UnitTypes.Melee;
	}

	public int TurnsToFormation { get; set; }
    public int Health { get; set; }
    public int Power { get; set; }
    public int Armor { get; set; }
    public UnitTypes Type { get; set; }

    public UnitCardDto ToDto()
    {
		UnitCardDto dto = new()
		{
			Name = Name,
			Image = Image,
			Description = Description,
			EnvoyCost = EnvoyCost.ToString(),
			Health = Health.ToString(),
			Armor = Armor.ToString(),
			Power = Power.ToString(),
			TurnToFormation = TurnsToFormation.ToString(),
			UnitTypeImage = Type.ToString()
		};

		return dto;
	}
}
