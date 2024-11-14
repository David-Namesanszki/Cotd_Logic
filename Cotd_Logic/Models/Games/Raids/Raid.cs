using Cotd_Data.Models.Games.Raids;
using Cotd_Logic.Models.Games.Decks;
using Cotd_Logic.Models.Games.Raids.Maps;
using Cotd_Logic.Models.Games.Raids.Maps.Locations;
using Cotd_Logic.Models.Games.Resources;

namespace Cotd_Logic.Models.Games.Raids;

public class Raid
{
    public Raid()
    {
    }

    public Raid(RaidData data)
    {
		Map = new Map(data.Map);
		Loot = new Resource(data.Loot);
		Deck = new Deck(data.Deck);
		CurrentLocation = Map.GetLocation(data.CurrentLocationId);
	}

    public Location CurrentLocation { get; set; } = new StartLocation();
	public Map Map { get; set; } = new Map();
    public Resource Loot { get; set; } = new Resource();
	public Deck Deck { get; set; } = new Deck();

	public RaidData ToData()
	{
		return new RaidData()
		{
			Map = Map.ToData(),
			Loot = Loot.ToData(),
			Deck = Deck.ToData(),
			CurrentLocationId = CurrentLocation.Id,
		};
	}
}
