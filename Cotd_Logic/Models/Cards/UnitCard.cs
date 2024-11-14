using Cotd_Data.Models.Cards;

namespace Cotd_Logic.Models.Cards;

public enum UnitTypes
{
    Melee,
    Ranged,
    Support
}

public class UnitCard : Card
{
	public UnitCard()
	{
	}

	public UnitCard(UnitCardData data) : base(data)
	{
		TurnsToFormation = data.TurnsToFormation;
		Health = data.Health;
		Power = data.Power;
		Armor = data.Armor;
		Type = UnitTypes.Melee;
	}

	public int TurnsToFormation { get; set; }
    public int Health { get; set; }
    public int Power { get; set; }
    public int Armor { get; set; }
    public UnitTypes Type { get; set; }

    public override UnitCardData ToData()
    {
		UnitCardData data = new()
		{
			Id = Id,
			Name = Name,
			Image = Image,
			Description = Description,
			EnvoyCost = EnvoyCost,
			Health = Health,
			Armor = Armor,
			Power = Power,
			TurnsToFormation = TurnsToFormation,
			Type = (Cotd_Data.Models.Cards.UnitTypes)Type,
			CardType = (Cotd_Data.Models.Cards.CardTypes)CardType,
		};

		return data;
	}

	public override string ToString()
	{
		return base.ToString() + "\n" +
			$"Armor: {Armor}\n" +
			$"Health: {Health}\n" +
			$"Power: {Power}\n" +
			$"TurnsToFormation: {TurnsToFormation}\n" +
			$"Type: {Type}\n";
	}
}
