using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.DataStorage.CardStorage.Interfaces;

namespace Cotd_Logic.DataStorage.CardStorage;

public class ConstructionCardStorage : IConstructionCardStorage
{
	private readonly IConstructionCardRepository _repo;

	public ConstructionCardStorage(IConstructionCardRepository repo)
	{
		_repo = repo;
	}

	public void UpdateCard(string id, string name, string description, string image, string envoyCost, string turnsToBuild, string armor, string power)
	{
		int intId = int.Parse(id);
		int intEnvoyCost = int.Parse(envoyCost);
		int intTurnsToBuild = int.Parse(turnsToBuild);
		int intArmor = int.Parse(armor);
		int intPower = int.Parse(power);

		_repo.UpdateCard(intId, name, description, image, intEnvoyCost, intTurnsToBuild, intArmor, intPower);
	}

	public void InsertCard(string name, string description, string image, string envoyCost, string turnsToBuild, string armor, string power)
	{
		int intEnvoyCost = int.Parse(envoyCost);
		int intTurnsToBuild = int.Parse(turnsToBuild);
		int intArmor = int.Parse(armor);
		int intPower = int.Parse(power);

		ConstructionCardData cardData = new()
		{
			Name = name,
			Description = description,
			Image = image,
			EnvoyCost = intEnvoyCost,
			TurnsToBuild = intTurnsToBuild,
			Armor = intArmor,
			Power = intPower
		};

		_repo.Insert(cardData);
	}

	public void RemoveCard(string id)
	{
		int intId = int.Parse(id);

		_repo.Remove(_repo.GetOne(intId));
	}
}
