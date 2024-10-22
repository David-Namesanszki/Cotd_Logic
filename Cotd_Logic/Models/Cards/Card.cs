using Cotd_Data.Models;
using Cotd_Logic.Dtos.CardDtos;

namespace Cotd_Logic.Models.Cards;

public abstract class Card
{
	protected Card(CardData cardData)
	{
		Id = cardData.Id;
		Name = cardData.Name;
		Description = cardData.Description;
		Image = cardData.Image;
		EnvoyCost = cardData.EnvoyCost;
		IsUnlocked = cardData.IsUnlocked;
	}

	protected Card()
	{

	}

	public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public int EnvoyCost { get; set; }
    public bool IsUnlocked { get; set; }

	public override string ToString()
	{
		return $"Card: {Name}\n" +
			   $"Id: {Id}\n" +
			   $"Description: {Description}\n" +
			   $"Image: {Image}\n" +
			   $"EnvoyCost: {EnvoyCost}\n" +
			   $"IsUnlocked: {IsUnlocked}";
	}
}
