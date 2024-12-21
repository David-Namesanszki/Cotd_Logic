using Cotd_Logic.BL.GameLogic.RaidLogics.DayPassSystem;
using Cotd_Logic.Models;
using Cotd_Logic.Models.LocationPaths;

namespace Cotd_Logic.BL.GameLogic.RaidLogics.TravelSystem;

public class TravelingService : ITravelingService
{
	private IDayPassService _dayPassService;

	public TravelingService(IDayPassService dayPassService)
	{
		_dayPassService = dayPassService;
	}

	public void Travel(Raid raid, LocationPath locationPath)
	{
		raid.CurrentLocation = locationPath.To;
		_dayPassService.PassDays(locationPath.DaysToTravel);

		if (_dayPassService.OutOfDays())
		{
		}
	}

	public bool CanTravel(Raid raid, LocationPath locationPath)
	{
		return raid.CurrentLocation == locationPath.From;
	}
}
