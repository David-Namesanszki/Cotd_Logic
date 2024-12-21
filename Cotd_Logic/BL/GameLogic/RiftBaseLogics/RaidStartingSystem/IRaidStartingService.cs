using Cotd_Logic.Models.Captains;

namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics.RaidStartingSystem
{
	public interface IRaidStartingService
	{
		void StartRaid(Captain selectedCaptain);
	}
}