using Cotd_Data.Models.Maps.LocationPaths;
using Cotd_Logic.Models.Common;
using Cotd_Logic.Models.Locations;
using Cotd_Logic.Models.Maps.Locations;

namespace Cotd_Logic.Models.LocationPaths;

public class LocationPath : Entity
{
    private string _fromId = string.Empty;
    private string _toId = string.Empty;

    public LocationPath()
    {
    }

    public LocationPath(LocationPathData locationPathData)
    {
        Id = locationPathData.Id;
        DaysToTravel = locationPathData.DaysToTravel;
        _fromId = locationPathData.FromId;
        _toId = locationPathData.ToId;
    }

    public LocationPath(int daysToTravel, Location from, Location to)
    {
        DaysToTravel = daysToTravel;
        From = from;
        To = to;
    }

    public int DaysToTravel { get; set; } = 0;
    public Location From { get; set; } = new StartLocation();
    public Location To { get; set; } = new EndLocation();

    public LocationPathData ToData()
    {
        return new LocationPathData()
        {
            Id = Id,
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
