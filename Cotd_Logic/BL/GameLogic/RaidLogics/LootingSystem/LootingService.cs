using Cotd_Data.ValueObjects;
using Cotd_Logic.Models;
using Cotd_Logic.Models.GameInfos;

namespace Cotd_Logic.BL.GameLogic.RaidLogics.LootingSystem;

public class LootingService
{
    private Raid _raid;

    public void GatherLoot(Loot resources)
    {
        _raid.Loot += resources;
    }
}
