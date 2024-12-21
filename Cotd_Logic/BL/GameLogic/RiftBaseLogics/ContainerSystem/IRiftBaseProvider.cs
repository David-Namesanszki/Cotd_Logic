using Cotd_Logic.Models;

namespace Cotd_Logic.BL.GameLogic.RaidLogics
{
	public interface IRiftBaseProvider
	{
		RiftBase GetRiftBase(string id);
		void SetRiftBase(string id, RiftBase riftBase);
	}
}