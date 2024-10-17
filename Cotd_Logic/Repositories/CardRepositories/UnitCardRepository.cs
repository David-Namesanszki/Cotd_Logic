using Cotd_Logic.Models.Cards;
using Cotd_Logic.Repositories.CardRepositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cotd_Logic.Repositories.CardRepositories;

public class UnitCardRepository(DbContext ctx) : BaseRepository<UnitCard>(ctx), IUnitCardRepository
{
	public override UnitCard GetOne(int id)
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
		int turnsToFormation,
		int health,
		int armor,
		int power,
		in UnitTypes type)
	{
		UnitCard card = this.GetOne(id);

		card.Name = name;
		card.Description = description;
		card.Image = image;
		card.EnvoyCost = envoyCost;
		card.TurnsToFormation = turnsToFormation;
		card.Health = health;
		card.Armor = armor;
		card.Power = power;
		card.Type = type;

		Ctx.SaveChanges();
	}
}
