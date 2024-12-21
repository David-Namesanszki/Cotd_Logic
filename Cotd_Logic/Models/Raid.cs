using Cotd_Data.Models.Games.Raids;
using Cotd_Data.ValueObjects;
using Cotd_Logic.Models.Captains;
using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.Common;
using Cotd_Logic.Models.Locations;
using Cotd_Logic.Models.Maps;

namespace Cotd_Logic.Models;

public class Raid : Entity
{
    public Raid()
    {
    }

    public Raid(Captain captain, Map map, IList<Card> unlockedCards)
    {
        Map = map;
        //Loot = RaidConfig.StartingLoot;
        Captain = captain;
		UnlockedCards = new List<Card>(unlockedCards);

	}

    public Raid(RaidData data)
    {
        Id = data.Id;
        Map = new Map(data.Map);
        Loot = data.Loot;
        Captain = new Captain(data.Captain);
        CurrentLocation = Map.GetLocation(data.CurrentLocationId);
    }

    public Location CurrentLocation { get; set; } = new StartLocation();
    public Map Map { get; set; } = new Map();
    public Loot Loot { get; set; } = new Loot();
    public IList<Card> Deck { get; set; } = [];
    public Captain Captain { get; set; } = new Captain();
    public int FireAmount { get; set; }
    public IList<Card> UnlockedCards { get; set; }
    public Battle? OngoingBattle { get; set; }

    public RaidData ToData()
    {
        return new RaidData()
        {
            Id = Id,
            Map = Map.ToData(),
            Loot = Loot,
            Captain = Captain.ToData(),
            CurrentLocationId = CurrentLocation.Id,
        };
    }
}
