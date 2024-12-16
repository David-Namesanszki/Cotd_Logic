using Cotd_Data.Models.Maps.Locations;
using Cotd_Data.ValueObjects;
using System.Numerics;

namespace Cotd_Logic.Models.Locations;

public class HarvestingSite : Location
{
    public HarvestingSite()
    {
    }
    public HarvestingSite(HarvestingSiteData locationData) : base(locationData)
    {
        DaysToHarvest = locationData.DaysToHarvest;
        Loot = locationData.Loot;
    }

    public int DaysToHarvest { get; set; } = 0;
    public Loot Loot { get; set; } = new Loot();

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
