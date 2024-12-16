using Cotd_Data.Models.Maps.Locations;
using System.Numerics;

namespace Cotd_Logic.Models.Locations;

public class StartLocation : Location
{
    public StartLocation()
    {
    }
    public StartLocation(LocationData locationData) : base(locationData)
    {
    }
}
