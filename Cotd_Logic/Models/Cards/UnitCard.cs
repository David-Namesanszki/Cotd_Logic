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
	public UnitCard(string name, string description, string image, int envoyCost, int turnsToFormation, int health, int power, int armor, UnitTypes unitType)
		: base(name, description, image, envoyCost)
	{
		TurnsToFormation = turnsToFormation;
		Health = health;
		Power = power;
		Armor = armor;
		UnitType = unitType;
		CardType = CardTypes.UnitCard;
	}

	public UnitCard()
	{
		CardType = CardTypes.UnitCard;
	}

	public UnitCard(UnitCardData data) : base(data)
	{
		TurnsToFormation = data.TurnsToFormation;
		Health = data.Health;
		Power = data.Power;
		Armor = data.Armor;
		UnitType = (UnitTypes)data.UnitType;
		CardType = CardTypes.UnitCard;
	}

	public int TurnsToFormation { get; set; }
    public int Health { get; set; }
    public int Power { get; set; }
    public int Armor { get; set; }
    public UnitTypes UnitType { get; set; }

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
			UnitType = (Cotd_Data.Models.Cards.UnitTypes)UnitType,
			CardType = Cotd_Data.Models.Cards.CardTypes.UnitCard,
			Effects = Effects.Select(x => x.ToData()).ToList()
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
			$"Type: {UnitType}\n";
	}
}
