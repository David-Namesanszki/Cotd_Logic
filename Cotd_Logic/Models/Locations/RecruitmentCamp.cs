using Cotd_Data.Models.Maps.Locations;

namespace Cotd_Logic.Models.Locations;

public class RecruitmentCamp : Location
{
    public RecruitmentCamp()
    {
    }
    public RecruitmentCamp(ICollection<string> cardChoiceIds)
    {
        CardChoiceIds = new List<string>(cardChoiceIds);
    }

    public RecruitmentCamp(RecruitmentCampData locationData) : base(locationData)
    {
        CardChoiceIds = locationData.CardChoiceIds;
    }

    public IList<string> CardChoiceIds { get; set; } = [];
}
