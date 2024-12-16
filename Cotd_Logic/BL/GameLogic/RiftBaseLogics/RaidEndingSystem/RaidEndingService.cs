using Cotd_Logic.Models;
using Cotd_Logic.Models.Captains;
using Cotd_Logic.Models.Games.Raids;
using Cotd_Logic.Models.Maps;

namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics.RaidStartingSystem;

public class RaidEndingService
{
	private RiftBase _game;
	 
	public void EndRaid()
	{
		if (!_game.OngoingRaid.Captain.IsDead)
		{
			_game.Resources += _game.OngoingRaid.Loot;
		}

		_game.OngoingRaid = null;
	}
}
