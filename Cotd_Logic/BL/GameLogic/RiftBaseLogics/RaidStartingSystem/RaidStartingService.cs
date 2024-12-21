using Cotd_Logic._Interfaces;
using Cotd_Logic.Models;
using Cotd_Logic.Models.Captains;
using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.Maps;

namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics.RaidStartingSystem;

public class RaidStarter : IRaidStarter
{
	private RiftBase _currentRiftBase;

	private readonly IMapGenerator _mapGenerator;
	private readonly IDataAccessor<Card> _cardAccessor;

	public void StartRaid(Captain selectedCaptain)
	{
		Map map = _mapGenerator.GenerateMap();
		IList<Card> cards = _cardAccessor.GetAll();

		_currentRiftBase.OngoingRaid = new Raid(selectedCaptain, map, cards);
	}
}
