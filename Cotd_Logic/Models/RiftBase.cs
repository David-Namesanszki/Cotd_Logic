using Cotd_Data.Models.GameInfos;
using Cotd_Data.ValueObjects;
using Cotd_Logic.Configs;
using Cotd_Logic.Models.Common;

namespace Cotd_Logic.Models;

public class RiftBase : Entity
{
    public RiftBase()
    {
    }

    public RiftBase(GameData gameData)
    {
        Id = gameData.Id;
        Name = gameData.Name;
        Resources = gameData.Resources;
        UnlockedCaptainIds = gameData.UnlockedCardIds;
        UnlockedCaptainIds = gameData.UnlockedCaptainIds;
        OngoingRaid = gameData.OngoingRaid != null ? new Raid(gameData.OngoingRaid) : null;
    }

    public RiftBase(string name)
    {
        Name = name;
        Resources = GameConfig.StartingResources;
        UnlockedCardIds = GameConfig.StartingCards;
        UnlockedCaptainIds = GameConfig.StartingCaptains;
        OngoingRaid = null;
    }

    public string Name { get; set; } = string.Empty;
    public Loot Resources { get; set; } = new Loot();
    public int PlayerXP { get; set; }
    public IList<string> UnlockedCardIds { get; } = [];
    public IList<string> UnlockedCaptainIds { get; } = [];
    public Raid? OngoingRaid { get; set; } = null;

    public GameData ToData()
    {
        return new GameData()
        {
            Id = Id,
            Name = Name,
            UnlockedCaptainIds = UnlockedCaptainIds,
            UnlockedCardIds = UnlockedCardIds,
            OngoingRaid = OngoingRaid?.ToData(),
            Resources = Resources
        };
    }
}
