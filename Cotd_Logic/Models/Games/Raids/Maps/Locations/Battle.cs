using Cotd_Data.Models.Games.Raids.Maps.Locations;
using Cotd_Logic.Models.Enemies;
using Cotd_Logic.Models.Games.Resources;

namespace Cotd_Logic.Models.Games.Raids.Maps.Locations;

public class Battle : Location
{
    public Battle()
    {
    }
    public Battle(BattleData locationData) : base(locationData)
	{
        Enemy = new Enemy(locationData.Enemy);
        Loot = new Resource(locationData.Loot);
	}

	public Enemy Enemy { get; set; } = new Enemy();
    public Resource Loot { get; set; } = new Resource();

    public override string ToString()
    {
        return $"{base.ToString()}, Enemy = {Enemy}, Loot = {Loot}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Battle other)
        {
            // Compare the base class (Location) properties first
            bool baseEqual = base.Equals(obj);

            // Then compare the Enemy and Loot properties
            return baseEqual && Enemy.Equals(other.Enemy) && Loot.Equals(other.Loot);
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), Enemy, Loot);
    }
}
