using Cotd_Logic.Models.Games.Resources;

namespace Cotd_Logic.Configs;

public static class RaidConfig
{
    public static Resource StartingLoot { get; set; } = new Resource(0, 0, 0);
}
