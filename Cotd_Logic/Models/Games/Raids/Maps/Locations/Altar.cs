using Cotd_Data.Models.Games.Raids.Maps.Locations;
using Cotd_Logic.Models.Games.Decks;

namespace Cotd_Logic.Models.Games.Raids.Maps.Locations;

public class Altar : Location
{
    public Altar()
    {
        
    }
    public Altar(AltarData locationData) : base(locationData)
	{
		CardChoises = new Deck(locationData.CardChoices);
	}

	public Deck CardChoises { get; set; } = new Deck();
}
