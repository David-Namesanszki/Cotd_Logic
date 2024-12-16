using Cotd_Data.Models.Captains;
using Cotd_Logic.Models.Common;

namespace Cotd_Logic.Models.Captains;

public class Captain : Entity
{
    public Captain()
    {
    }
    public Captain(CaptainData data)
    {
		Id = data.Id;
		Image = data.Image;
		Name = data.Name;
		Health = data.Health;
		Power = data.Power;
		Armor = data.Armor;
		CardIds = data.CardIds;
    }

	public Captain(string image, string name, int health, int power, int armor, IList<string> cardIds)
	{
		Image = image;
		Name = name;
		Health = health;
		Power = power;
		Armor = armor;
		CardIds = cardIds;
	}

	public CaptainData ToData()
	{
		CaptainData data = new CaptainData()
		{
			Id = Id,
			Image = Image,
			Name = Name,
			Health = Health,
			Power = Power,
			Armor = Armor,
			CardIds = CardIds,
		};

		return data;
	}

    public string Image { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public int Health { get; set; } = 0;
	public int Power { get; set; } = 0;
	public int Armor { get; set; } = 0;
	public IList<string> CardIds { get; set; } = [];
	public bool IsDead => Health <= 0;
}
