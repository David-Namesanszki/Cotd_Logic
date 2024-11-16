using Cotd_Data.Models.Games.Raids.Maps;
using Cotd_Data.Models.Games.Raids.Maps.Locations;
using Cotd_Logic.Models.Games.Raids.Maps.LocationPaths;
using Cotd_Logic.Models.Games.Raids.Maps.Locations;

namespace Cotd_Logic.Models.Games.Raids.Maps;

public class Map
{
    public Map()
    {
    }

    public Map(MapData mapData)
    {
		Locations = mapData.Locations.Select(CreateLocation).ToList();
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
            Locations = Locations.Select(l => l.ToData()).ToList(),
            LocationPaths = LocationPaths.Select(l => l.ToData()).ToList(),
        };
    }

    public List<LocationPath> LocationPaths { get; set; } = [];
    public List<Location> Locations { get; set; } = [];
    public Location StartLocation
    {
        get
        {
			return Locations.FirstOrDefault(l => l is StartLocation);
		}
	}

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
            Cotd_Data.Models.Games.Raids.Maps.Locations.LocationTypes.Altar => new Altar(locationData as AltarData ?? throw new InvalidCastException("Invalid AltarData")),
            Cotd_Data.Models.Games.Raids.Maps.Locations.LocationTypes.Battle => new Battle(locationData as BattleData ?? throw new InvalidCastException("Invalid BattleData")),
            Cotd_Data.Models.Games.Raids.Maps.Locations.LocationTypes.HarvestingSite => new HarvestingSite(locationData as HarvestingSiteData ?? throw new InvalidCastException("Invalid HarvestingSiteData")),
            Cotd_Data.Models.Games.Raids.Maps.Locations.LocationTypes.RecruitmentCamp => new RecruitmentCamp(locationData as RecruitmentCampData ?? throw new InvalidCastException("Invalid RecruitmentCampData")),
            Cotd_Data.Models.Games.Raids.Maps.Locations.LocationTypes.Start => new StartLocation(locationData as StartLocationData ?? throw new InvalidCastException("Invalid StartLocationData")),
            Cotd_Data.Models.Games.Raids.Maps.Locations.LocationTypes.End => new EndLocation(locationData as EndLocationData ?? throw new InvalidCastException("Invalid EndLocationData")),
            Cotd_Data.Models.Games.Raids.Maps.Locations.LocationTypes.Undefined => throw new ArgumentException("Location type is undefined"),
            _ => throw new ArgumentException("Location type is unknown")
        };
    }
}
