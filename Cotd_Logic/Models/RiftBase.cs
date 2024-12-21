using Cotd_Data.Models.GameInfos;
using Cotd_Data.ValueObjects;
using Cotd_Logic.Models.Captains;
using Cotd_Logic.Models.Cards;
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
        UnlockedCaptains = gameData.UnlockedCardIds;
        UnlockedCaptains = gameData.UnlockedCaptainIds;
        OngoingRaid = gameData.OngoingRaid != null ? new Raid(gameData.OngoingRaid) : null;
    }

    public RiftBase(string name)
    {
        Name = name;
        //Resources = GameConfig.StartingResources;
        //UnlockedCardIds = GameConfig.StartingCards;
        //UnlockedCaptainIds = GameConfig.StartingCaptains;
        OngoingRaid = null;
    }

    public string Name { get; set; } = string.Empty;
    public Loot Resources { get; set; } = new Loot();
    public int PlayerXP { get; set; }
    public IList<Card> UnlockedCards { get; } = [];
    public IList<Captain> UnlockedCaptains { get; } = [];
    public Raid? OngoingRaid { get; set; } = null;

    public GameData ToData()
    {
        return new GameData()
        {
            Id = Id,
            Name = Name,
            UnlockedCaptainIds = UnlockedCaptains,
            UnlockedCardIds = UnlockedCards,
            OngoingRaid = OngoingRaid?.ToData(),
            Resources = Resources
        };
    }
}
