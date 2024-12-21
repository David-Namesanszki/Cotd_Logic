using Cotd_Logic.Models;
using Cotd_Logic.Models.LocationPaths;

namespace Cotd_Logic.BL.GameLogic.RaidLogics.TravelSystem
{
    public interface ITravelingService
	{
		bool CanTravel(Raid raid, LocationPath locationPath);
		void Travel(Raid raid, LocationPath locationPath);
	}
}