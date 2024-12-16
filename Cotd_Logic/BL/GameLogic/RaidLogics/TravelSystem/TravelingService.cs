using Cotd_Logic.BL.GameLogic.RaidLogics.DayPassSystem;
using Cotd_Logic.Models;
using Cotd_Logic.Models.LocationPaths;

namespace Cotd_Logic.BL.GameLogic.RaidLogics.TravelSystem;

public class TravelingService : ITravelingService
{
	private Raid _raid;

	private IDayPassService _dayPassService;

	public TravelingService(Raid raid, IDayPassService dayPassService)
	{
		_raid = raid;
		_dayPassService = dayPassService;
	}

	public void Travel(LocationPath locationPath)
	{
		_raid.CurrentLocation = locationPath.To;
		_dayPassService.PassDays(locationPath.DaysToTravel);

		if (_dayPassService.OutOfDays())
		{
			_raid.RanOutOfDays();
		}
	}

	public bool CanTravel(LocationPath locationPath)
	{
		return _raid.CurrentLocation == locationPath.From;
	}
}
