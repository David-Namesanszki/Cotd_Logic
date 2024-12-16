using Cotd_Data.Models.Maps;
using Cotd_Data.Models.Maps.LocationPaths;
using Cotd_Data.Models.Maps.Locations;
using Cotd_Logic.Models.Common;
using Cotd_Logic.Models.LocationPaths;
using Cotd_Logic.Models.Locations;
using Cotd_Logic.Models.Maps.Locations;

namespace Cotd_Logic.Models.Maps;

public class Map : Entity
{
    public Map()
    {
    }

    public Map(MapData mapData)
    {
        Id = mapData.Id;
        Locations = mapData.Locations.Select(CreateLocation).ToList();

        foreach (LocationPathData locationPathData in mapData.LocationPaths)
        {
            Location from = Locations.FirstOrDefault(l => l.Id == locationPathData.FromId) ?? throw new KeyNotFoundException($"Not location with this id {locationPathData.FromId}");
            Location to = Locations.FirstOrDefault(l => l.Id == locationPathData.ToId) ?? throw new KeyNotFoundException($"Not location with this id {locationPathData.FromId}");

            LocationPaths.Add(new LocationPath(locationPathData.DaysToTravel, from, to));
        }

        CurrentLocation = Locations.FirstOrDefault(l => l.Id == mapData.CurrentLocationId) ?? throw new KeyNotFoundException($"Not location with this id {mapData.CurrentLocationId}");

    }

    public Map(List<LocationPath> locationPaths, List<Location> locations)
    {
        LocationPaths = locationPaths;
        Locations = locations;
    }

    public MapData ToData()
    {
        return new MapData()
        {
            Id = Id,
            CurrentLocationId = CurrentLocation.Id,
            Locations = Locations.Select(l => l.ToData()).ToList(),
            LocationPaths = LocationPaths.Select(l => l.ToData()).ToList(),
        };
    }

    public List<LocationPath> LocationPaths { get; set; } = [];
    public List<Location> Locations { get; set; } = [];
    public Location CurrentLocation { get; set; } = new StartLocation();

    public void AddLocationPath(LocationPath locationPath)
    {
        LocationPaths.Add(locationPath);
    }

    public void AddLocation(Location location)
    {
        Locations.Add(location);
    }

    public Location GetLocation(string id)
    {
        return Locations.FirstOrDefault(x => x.Id == id) ?? throw new ArithmeticException($"No location with this id: {id}");
    }

    private Location CreateLocation(LocationData locationData)
    {
        return locationData.LocationType switch
        {
            Cotd_Data.Models.Maps.Locations.LocationTypes.Altar => new Altar(locationData as AltarData ?? throw new InvalidCastException("Invalid AltarData")),
            Cotd_Data.Models.Maps.Locations.LocationTypes.Battle => new Battle(locationData as BattleData ?? throw new InvalidCastException("Invalid BattleData")),
            Cotd_Data.Models.Maps.Locations.LocationTypes.HarvestingSite => new HarvestingSite(locationData as HarvestingSiteData ?? throw new InvalidCastException("Invalid HarvestingSiteData")),
            Cotd_Data.Models.Maps.Locations.LocationTypes.RecruitmentCamp => new RecruitmentCamp(locationData as RecruitmentCampData ?? throw new InvalidCastException("Invalid RecruitmentCampData")),
            Cotd_Data.Models.Maps.Locations.LocationTypes.Start => new StartLocation(locationData as StartLocationData ?? throw new InvalidCastException("Invalid StartLocationData")),
            Cotd_Data.Models.Maps.Locations.LocationTypes.End => new EndLocation(locationData as EndLocationData ?? throw new InvalidCastException("Invalid EndLocationData")),
            Cotd_Data.Models.Maps.Locations.LocationTypes.Undefined => throw new ArgumentException("Location type is undefined"),
            _ => throw new ArgumentException("Location type is unknown")
        };
    }
}
