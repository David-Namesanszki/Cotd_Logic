using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.DataStorage.CardStorage.Interfaces;

namespace Cotd_Logic.DataStorage.CardStorage;

public class UnitCardStorage : IUnitCardStorage
{
	private readonly IUnitCardRepository _repo;

	public UnitCardStorage(IUnitCardRepository repo)
	{
		_repo = repo;
	}

	public void UpdateCard(string id, string name, string description, string image, string envoyCost, string turnsToFormation, string health, string armor, string power, string unitType)
	{
		int intId = int.Parse(id);
		int intEnvoyCost = int.Parse(envoyCost);
		int intTurnsToFormation = int.Parse(turnsToFormation);
		int intArmor = int.Parse(armor);
		int intPower = int.Parse(power);
		int intHealth = int.Parse(health);
		Enum.TryParse(unitType, out UnitTypes type);

		_repo.UpdateCard(intId, name, description, image, intEnvoyCost, intTurnsToFormation, intHealth, intArmor, intPower, type);
	}

	public void InsertCard(string name, string description, string image, string envoyCost, string turnsToFormation, string health, string armor, string power, string unitType)
	{
		int intEnvoyCost = int.Parse(envoyCost);
		int intTurnsToFormation = int.Parse(turnsToFormation);
		int intArmor = int.Parse(armor);
		int intPower = int.Parse(power);
		int intHealth = int.Parse(health);
		Enum.TryParse(unitType, out UnitTypes type);

		UnitCardData cardData = new()
		{
			Name = name,
			Description = description,
			Image = image,
			EnvoyCost = intEnvoyCost,
			TurnsToFormation = intTurnsToFormation,
			Armor = intArmor,
			Power = intPower,
			Health = intHealth,
			Type = type
		};

		_repo.Insert(cardData);
	}

	public void RemoveCard(string id)
	{
		int intId = int.Parse(id);

		_repo.Remove(_repo.GetOne(intId));
	}
}
