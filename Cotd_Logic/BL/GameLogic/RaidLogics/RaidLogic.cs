using Cotd_Logic.BL.GameLogic.RaidLogics.ObtainCardSystem;
using Cotd_Logic.BL.GameLogic.RaidLogics.TravelSystem;
using Cotd_Logic.Models;
using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.GameInfos;
using Cotd_Logic.Models.LocationPaths;
using Cotd_Logic.Models.Locations;
using System.Linq;

namespace Cotd_Logic.BL.GameLogic.RaidLogics;

public class RaidLogic
{
    private Raid _onGoingRaid;

    private readonly ITravelingService _travelingService;
    private readonly ICardObtainingSystem _cardObtainer;

    public RaidLogic(Raid onGoingRaid, ITravelingService travelingService, ICardObtainingSystem cardObtainer)
    {
        _onGoingRaid = onGoingRaid;
        _travelingService = travelingService;
        _cardObtainer = cardObtainer;
    }

    public Location Travel(string pathId)
    {
        LocationPath locationPath = _onGoingRaid.Map.LocationPaths.FirstOrDefault(p => p.Id == pathId);

        if (_travelingService.CanTravel(locationPath))
        {
            _travelingService.Travel(locationPath);
        }

        return _onGoingRaid.CurrentLocation;
    }

    public void ObtainCard(string cardId)
    {
        Card card = _onGoingRaid.UnlockedCards.FirstOrDefault(p => p.Id == cardId);

        _cardObtainer.ObtainCard(card);
    }
}
