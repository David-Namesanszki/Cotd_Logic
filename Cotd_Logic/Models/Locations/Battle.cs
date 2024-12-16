using Cotd_Data.Models.Maps.Locations;
using Cotd_Data.ValueObjects;
using Cotd_Logic.Models.Enemies;

namespace Cotd_Logic.Models.Locations;

public class Battle : Location
{
    public Battle()
    {
    }
    public Battle(BattleData locationData) : base(locationData)
    {
        Enemy = new Enemy(locationData.Enemy);
        Loot = locationData.Loot;
    }

    public Enemy Enemy { get; set; } = new Enemy();
    public Loot Loot { get; set; } = new Loot();

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
