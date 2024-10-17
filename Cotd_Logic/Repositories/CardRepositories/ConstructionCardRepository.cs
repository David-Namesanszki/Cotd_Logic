using Cotd_Logic.Models.Cards;
using Cotd_Logic.Repositories.CardRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cotd_Logic.Repositories.CardRepositories;

public class ConstructionCardRepository(DbContext ctx) : BaseRepository<ConstructionCard>(ctx), IConstructionCardRepository
{
	public override ConstructionCard GetOne(int id)
	{
		var card = this.GetAll().FirstOrDefault(c => c.Id == id);
		return card ?? throw new KeyNotFoundException($"Card with ID {id} not found.");
	}

	public void UpdateCard(
		int id,
		string name,
		string description,
		string image,
		int envoyCost,
		int turnsToBuild,
		int armor,
		int power)
	{
		ConstructionCard card = GetOne(id);

		card.Name = name;
		card.Description = description;
		card.Image = image;
		card.EnvoyCost = envoyCost;
		card.TurnsToBuild = turnsToBuild;
		card.Armor = armor;
		card.Power = power;

		Ctx.SaveChanges();
	}
}
