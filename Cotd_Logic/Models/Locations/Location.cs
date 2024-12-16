using Cotd_Data.Models.Maps.Locations;
using Cotd_Data.ValueObjects;
using Cotd_Logic.Models.Common;
using Cotd_Logic.Models.LocationPaths;
using System.Numerics;

namespace Cotd_Logic.Models.Locations;

public enum LocationTypes
{
    Altar,
    Battle,
    HarvestingSite,
    RecruitmentCamp,
    Start,
    End,
    Undefined
}
public abstract class Location : Entity
{
    protected Location()
    {
    }
    protected Location(LocationData locationData)
    {
        Id = locationData.Id;
        Coordinates = locationData.Coordinates;
        Visited = locationData.Visited;
        LocationType = (LocationTypes)locationData.LocationType;
    }

    public CubeCoord Coordinates { get; set; } = new CubeCoord();
    public bool Visited { get; set; }
    public LocationTypes LocationType { get; set; } = LocationTypes.Undefined;
    public List<LocationPath> LocationPaths { get; set; } = [];

    public LocationData ToData()
    {
        return new LocationData()
        {
            Id = Id,
            Coordinates = Coordinates,
            Visited = Visited,
            LocationType = (Cotd_Data.Models.Maps.Locations.LocationTypes)LocationType,
            LocationPaths = LocationPaths.Select(l => l.ToData()).ToList(),
        };
    }

    public void AddLocationPath(LocationPath locationPath)
    {
        LocationPaths.Add(locationPath);
    }

    public override string ToString()
    {
        return $"Location: Coordinates = {Coordinates}, Visited = {Visited}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Location other)
        {
            return Coordinates == other.Coordinates && Visited == other.Visited;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Coordinates, Visited);
    }
}
