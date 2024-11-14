using Cotd_Data.Models.Games.Raids.Maps.LocationPaths;
using Cotd_Logic.Models.Games.Raids.Maps.Locations;

namespace Cotd_Logic.Models.Games.Raids.Maps.LocationPaths;

public class LocationPath
{
	private string _fromId = string.Empty;
	private string _toId = string.Empty;

	public LocationPath()
    {
    }

    public LocationPath(LocationPathData locationPathData)
    {
        DaysToTravel = locationPathData.DaysToTravel;
		_fromId = locationPathData.FromId;
		_toId = locationPathData.ToId;
    }

    public int DaysToTravel { get; set; } = 0;
    public Location From { get; set; } = new StartLocation();
    public Location To { get; set; } = new EndLocation();

	public LocationPathData ToData()
    {
        return new LocationPathData()
        {
            DaysToTravel = DaysToTravel,
            FromId = From.Id,
            ToId = To.Id,
        };
    }

    public void LoadLocations(List<Location> locations)
    {
        From = locations.FirstOrDefault(l => l.Id == _fromId) ?? throw new ArithmeticException($"No location with this id: {_fromId}");
		To = locations.FirstOrDefault(l => l.Id == _toId) ?? throw new ArithmeticException($"No location with this id: {_toId}");
	}
}
