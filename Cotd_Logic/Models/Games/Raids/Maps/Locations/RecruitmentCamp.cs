using Cotd_Data.Models.Games.Raids.Maps.Locations;
using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.Games.Decks;
using System.Numerics;

namespace Cotd_Logic.Models.Games.Raids.Maps.Locations;

public class RecruitmentCamp : Location
{
    public RecruitmentCamp()
    {
    }
    public RecruitmentCamp(RecruitmentCampData locationData) : base(locationData)
	{
		CardChoices = new Deck(locationData.CardChoices);
	}

	public Deck CardChoices { get; set; } = new Deck();
}
