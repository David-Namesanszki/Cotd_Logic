using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.DataStorage.CardStorage.Interfaces;

namespace Cotd_Logic.DataStorage.CardStorage;

public class CommandCardStorage : ICommandCardStorage
{
	private readonly ICommandCardRepository _repo;

	public CommandCardStorage(ICommandCardRepository repo)
	{
		_repo = repo;
	}

	public void UpdateCard(string id, string name, string description, string image, string envoyCost)
	{
		int intId = int.Parse(id);
		int intEnvoyCost = int.Parse(envoyCost);

		_repo.UpdateCard(intId, name, description, image, intEnvoyCost);
	}

	public void InsertCard(string name, string description, string image, string envoyCost)
	{
		int intEnvoyCost = int.Parse(envoyCost);

		CommandCardData cardData = new()
		{
			Name = name,
			Description = description,
			Image = image,
			EnvoyCost = intEnvoyCost
		};

		_repo.Insert(cardData);
	}

	public void RemoveCard(string id)
	{
		int intId = int.Parse(id);

		_repo.Remove(_repo.GetOne(intId));
	}
}
