using Cotd_Data.Models.Games.Raids;
using Cotd_Logic.Configs;
using Cotd_Logic.Models.Captains;
using Cotd_Logic.Models.Games.Raids.Maps;
using Cotd_Logic.Models.Games.Raids.Maps.Locations;
using Cotd_Logic.Models.Games.Resources;

namespace Cotd_Logic.Models.Games.Raids;

public class Raid
{
	public Raid()
	{
	}

	public Raid(Captain captain, Map map)
	{
		Map = map;
		CardIds = captain.CardIds;
		Loot = RaidConfig.StartingLoot;
		Captain = captain;
		CurrentLocation = Map.StartLocation;
	}

	public Raid(RaidData data)
	{
		Map = new Map(data.Map);
		Loot = new Resource(data.Loot);
		CardIds = data.CardIds;
		Captain = new Captain(data.Captain);
		CurrentLocation = Map.GetLocation(data.CurrentLocationId);
	}

	public Location CurrentLocation { get; set; } = new StartLocation();
	public Map Map { get; set; } = new Map();
	public Resource Loot { get; set; } = new Resource();
	public IList<string> CardIds { get; set; } = [];
	public Captain Captain { get; set; } = new Captain();

	public RaidData ToData()
	{
		return new RaidData()
		{
			Map = Map.ToData(),
			Loot = Loot.ToData(),
			CardIds = CardIds,
			Captain = Captain.ToData(),
			CurrentLocationId = CurrentLocation.Id,
		};
	}
}
