using Cotd_Logic.BL.GameLogic.RaidLogics;
using Cotd_Logic.BL.GameLogic.RaidLogics.DayPassSystem;
using Cotd_Logic.BL.GameLogic.RaidLogics.TravelSystem;
using Cotd_Logic.Models;

namespace Cotd_Logic.BL.Factories;

public static class RaidFactory
{
    public static RaidLogic RaidLogic{ get; set; }

    public static void Init()
    {
        IDayPassService dayPassService = new DayPassService(180);
        ITravelingService travelingService = new TravelingService(dayPassService);

        RaidLogic = new RaidLogic(travelingService);
    }
}
