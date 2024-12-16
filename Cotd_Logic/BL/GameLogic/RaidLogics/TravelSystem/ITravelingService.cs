using Cotd_Logic.Models.LocationPaths;

namespace Cotd_Logic.BL.GameLogic.RaidLogics.TravelSystem
{
    public interface ITravelingService
	{
		bool CanTravel(LocationPath locationPath);
		void Travel(LocationPath locationPath);
	}
}