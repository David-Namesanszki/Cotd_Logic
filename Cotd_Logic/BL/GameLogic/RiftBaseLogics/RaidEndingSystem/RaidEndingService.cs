using Cotd_Logic.Models;

namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics.RaidEndingSystem;

public class RaidEndingService : IRaidEndingService
{
	private RiftBase _riftBase;

	public void EndRaid()
	{
		if (_riftBase.OngoingRaid == null)
		{
			throw new ArgumentNullException("There is no ongoing raid");
		}

		if (!_riftBase.OngoingRaid.Captain.IsDead)
		{
			_riftBase.Resources += _riftBase.OngoingRaid.Loot;
		}

		_riftBase.OngoingRaid = null;
	}
}
