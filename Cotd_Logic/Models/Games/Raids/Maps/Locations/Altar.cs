using Cotd_Data.Models.Games.Raids.Maps.Locations;

namespace Cotd_Logic.Models.Games.Raids.Maps.Locations;

public class Altar : Location
{
    public Altar()
    {
    }

    public Altar(IList<string> cardChoises)
    {
        CardChoises = new List<string>(cardChoises);
    }


    public Altar(AltarData locationData) : base(locationData)
	{
		CardChoises = locationData.CardChoiceIds;
	}

	public IList<string> CardChoises { get; set; } = [];

	
}
