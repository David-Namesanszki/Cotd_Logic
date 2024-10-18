using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.DataStorage.CardStorage.Interfaces;

namespace Cotd_Logic.DataStorage.CardStorage;

public class FireCardStorage : IFireCardStorage
{
	private readonly IFireCardRepository _repo;

	public FireCardStorage(IFireCardRepository repo)
	{
		_repo = repo;
	}

	public void UpdateCard(string id, string name, string description, string image, string envoyCost, string fireCost)
	{
		int intId = int.Parse(id);
		int intEnvoyCost = int.Parse(envoyCost);
		int intFireCost = int.Parse(fireCost);

		_repo.UpdateCard(intId, name, description, image, intEnvoyCost, intFireCost);
	}

	public void InsertCard(string name, string description, string image, string envoyCost, string fireCost)
	{
		int intEnvoyCost = int.Parse(envoyCost);
		int intFireCost = int.Parse(fireCost);

		FireCardData cardData = new()
		{
			Name = name,
			Description = description,
			Image = image,
			EnvoyCost = intEnvoyCost,
			FireCost = intFireCost
		};

		_repo.Insert(cardData);
	}

	public void RemoveCard(string id)
	{
		int intId = int.Parse(id);

		_repo.Remove(_repo.GetOne(intId));
	}
}
