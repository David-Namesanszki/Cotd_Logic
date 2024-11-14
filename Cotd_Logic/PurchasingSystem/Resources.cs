namespace Cotd_Logic.CardPurchase;

public enum ResourceTypes
{
	Heartwood,
	BarkOre,
	BloodSap,
}

public class Resources
{
    public Dictionary<ResourceTypes, int> Amounts { get; set; }

    public Resources(Dictionary<ResourceTypes, int> amounts)
    {
        Amounts = amounts;
    }

    public Resources(int heartwood, int barkOre, int bloodSap)
    {
        Amounts = new Dictionary<ResourceTypes, int>()
        {
            { ResourceTypes.Heartwood, heartwood },
            { ResourceTypes.BarkOre, barkOre },
            { ResourceTypes.BloodSap, bloodSap }
        };
    }
}
