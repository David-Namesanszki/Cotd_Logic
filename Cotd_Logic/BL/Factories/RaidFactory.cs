using Cotd_Logic.BL.GameLogic.RaidLogics;
using Cotd_Logic.BL.GameLogic.RaidLogics.DayPassSystem;
using Cotd_Logic.BL.GameLogic.RaidLogics.ObtainCardSystem;
using Cotd_Logic.BL.GameLogic.RaidLogics.TravelSystem;
using Cotd_Logic.Models;

namespace Cotd_Logic.BL.Factories;

public static class RaidFactory
{
    public static RaidLogic RaidLogic{ get; set; }

    public static void Init(Raid onGoingRaid)
    {
        IDayPassService dayPassService = new DayPassService(180);
        ITravelingService travelingService = new TravelingService(onGoingRaid, dayPassService);
        ICardObtainingSystem cardObtainingSystem = new CardObtainingSystem(onGoingRaid);

        RaidLogic = new RaidLogic(onGoingRaid, travelingService, cardObtainingSystem);
    }
}
