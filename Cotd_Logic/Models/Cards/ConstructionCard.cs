using Cotd_Data.Models.Cards;

namespace Cotd_Logic.Models.Cards;

public class ConstructionCard : Card
{
    public ConstructionCard()
    {
    }

    public ConstructionCard(ConstructionCardData cardData) : base(cardData)
	{
		Armor = cardData.Armor;
		Power = cardData.Power;
		TurnsToBuild = cardData.TurnsToBuild;
	}

	public int Armor { get; set; }
	public int Power { get; set; }
	public int TurnsToBuild { get; set; }

	public override ConstructionCardData ToData()
	{
		ConstructionCardData data = new()
		{
			Id = Id,
			Name = Name,
			Image = Image,
			Description = Description,
			EnvoyCost = EnvoyCost,
			Armor = Armor,
			Power = Power,
			TurnsToBuild = TurnsToBuild,
			CardType = (Cotd_Data.Models.Cards.CardTypes)CardType,
		};

		return data;
	}

	public override string ToString()
	{
		return base.ToString() + "\n" +
			$"Armor: {Armor}\n" +
			$"Power: {Power}\n" +
			$"TurnsToBuild: {TurnsToBuild}\n";
	}
}
