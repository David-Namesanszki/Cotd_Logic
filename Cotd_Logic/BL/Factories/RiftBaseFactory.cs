using Cotd_Logic.BL.GameLogic.RaidLogics;
using Cotd_Logic.BL.GameLogic.RiftBaseLogics;

namespace Cotd_Logic.BL.Factories;

public static class RiftBaseFactory
{
	public static RiftBaseLogic RiftBaseLogic { get; set; }

	public static void Init()
	{
		RiftBaseLogic = new RiftBaseLogic();
	}
}
