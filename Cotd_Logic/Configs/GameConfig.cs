using Cotd_Logic.Models.Games.Resources;

namespace Cotd_Logic.Configs;

public static class GameConfig
{
    public static Resource StartingResources { get; set; } = new Resource(0, 0, 0);
    public static IList<string> UnlockedCards { get; set; } = new List<string>()
    {
        "Card1",
        "Card2"
    };

	public static IList<string> UnlockedCaptains { get; set; } = new List<string>()
	{
		"Card1",
		"Card2"
	};
}
