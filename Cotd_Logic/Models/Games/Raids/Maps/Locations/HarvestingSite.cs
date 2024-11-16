using Cotd_Data.Models.Games.Raids.Maps.Locations;
using Cotd_Logic.Models.Games.Resources;
using System.Numerics;

namespace Cotd_Logic.Models.Games.Raids.Maps.Locations;

public class HarvestingSite : Location
{
    public HarvestingSite()
    {
    }
    public HarvestingSite(HarvestingSiteData locationData) : base(locationData)
	{
		DaysToHarvest = locationData.DaysToHarvest;
		Loot = new Resource(locationData.Loot);
	}

	public int DaysToHarvest { get; set; } = 0;
    public Resource Loot { get; set; } = new Resource();

    public override bool Equals(object? obj)
    {
        if (obj is HarvestingSite other)
        {
            // Compare the base class (Location) properties first
            bool baseEqual = base.Equals(obj);

            // Then compare the DaysToHarvest and Loot properties
            return baseEqual && DaysToHarvest == other.DaysToHarvest && Loot.Equals(other.Loot);
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), DaysToHarvest, Loot);
    }
}
