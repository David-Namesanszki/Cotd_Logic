using Cotd_Logic.BL.GameLogic.RaidLogics.TravelSystem;
using Cotd_Logic.Models;
using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.LocationPaths;
using Cotd_Logic.Models.Locations;
using System.Runtime.CompilerServices;

namespace Cotd_Logic.BL.GameLogic.RaidLogics;

public class RaidLogic
{
    private readonly ITravelingService _travelingService;
    private readonly IRiftBaseProvider _riftBaseProvider;

	public RaidLogic(ITravelingService travelingService, IRiftBaseProvider riftBaseProvider)
	{
		_travelingService = travelingService;
		_riftBaseProvider = riftBaseProvider;
	}

	public Location Travel(string riftBaseId, string pathId)
    {
        Raid raid = GetOngoingRaid(riftBaseId);

		LocationPath locationPath = raid.Map.LocationPaths.FirstOrDefault(p => p.Id == pathId) ??
			throw new KeyNotFoundException("There is no location with this id");

		if (_travelingService.CanTravel(raid, locationPath))
        {
            _travelingService.Travel(raid, locationPath);
        }

        return raid.CurrentLocation;
    }

    public void ObtainCard(string riftBaseId, string cardId)
    {
		Raid raid = GetOngoingRaid(riftBaseId);

		Card card = raid.UnlockedCards.FirstOrDefault(p => p.Id == cardId) ??
            throw new KeyNotFoundException("There is no card with this id");

		raid.Deck.Add(card);
    }

    public void LoseCard(string riftBaseId, string cardId)
    {
		Raid raid = GetOngoingRaid(riftBaseId);

		Card card = raid.UnlockedCards.FirstOrDefault(p => p.Id == cardId) ??
			throw new KeyNotFoundException("There is no card with this id");

		raid.Deck.Remove(card);
	}

	private Raid GetOngoingRaid(string riftBaseId)
	{
		RiftBase riftBase = _riftBaseProvider.GetRiftBase(riftBaseId);

		if (riftBase.OngoingRaid == null)
		{
			throw new ArgumentNullException("There is no ongoing raid for htis rift base");
		}

		return riftBase.OngoingRaid;
	}
}
