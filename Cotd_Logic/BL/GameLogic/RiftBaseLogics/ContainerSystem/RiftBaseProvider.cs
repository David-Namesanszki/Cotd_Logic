using Cotd_Logic.Models;

namespace Cotd_Logic.BL.GameLogic.RaidLogics;

public class RiftBaseProvider : IRiftBaseProvider
{
	IDictionary<string, RiftBase> _riftBaseDict = new Dictionary<string, RiftBase>();

	public RiftBase GetRiftBase(string id)
	{
		return _riftBaseDict[id];
	}

	public void SetRiftBase(string id, RiftBase riftBase)
	{
		_riftBaseDict[id] = riftBase;
	}
}
