using Cotd_Data.Models.Games.Resources;

namespace Cotd_Logic.Models.Games.Resources;

public class Resource
{
	public Resource()
	{
	}

	public Resource(ResourceData data)
    {
		HeartwoodAmount = data.HeartwoodAmount;
		BarkOreAmount = data.BarkOreAmount;
		BloodSapAmount = data.BloodSapAmount;
	}

    public Resource(int heartwoodAmount, int barkOreAmount, int bloodSapAmount)
	{
		HeartwoodAmount = heartwoodAmount;
		BarkOreAmount = barkOreAmount;
		BloodSapAmount = bloodSapAmount;
	}

	public ResourceData ToData()
	{
		ResourceData data = new ResourceData()
		{
			HeartwoodAmount = HeartwoodAmount,
			BarkOreAmount = BarkOreAmount,
			BloodSapAmount = BloodSapAmount
		};

		return data;
	}

	public Resource Clone()
	{
		return new Resource
		{
			HeartwoodAmount = this.HeartwoodAmount,
			BarkOreAmount = this.BarkOreAmount,
			BloodSapAmount = this.BloodSapAmount
		};
	}

	public int HeartwoodAmount { get; set; } = 0;
	public int BarkOreAmount { get; set; } = 0;
	public int BloodSapAmount { get; set; } = 0;

	public override string ToString()
	{
		return $"ResourceData: HeartwoodAmount = {HeartwoodAmount}, BarkOreAmount = {BarkOreAmount}, BloodSapAmount = {BloodSapAmount}";
	}

	public static Resource operator +(Resource r1, Resource r2)
	{
		return new Resource(new ResourceData()
		{
			HeartwoodAmount = r1.HeartwoodAmount + r2.HeartwoodAmount,
			BarkOreAmount = r1.BarkOreAmount + r2.BarkOreAmount,
			BloodSapAmount = r1.BloodSapAmount + r2.BloodSapAmount
		});
	}
	public static Resource operator -(Resource r1, Resource r2)
	{
		return new Resource(new ResourceData()
		{
			HeartwoodAmount = r1.HeartwoodAmount - r2.HeartwoodAmount,
			BarkOreAmount = r1.BarkOreAmount - r2.BarkOreAmount,
			BloodSapAmount = r1.BloodSapAmount - r2.BloodSapAmount
		});
	}

	public static Resource Zero()
	{
		return new Resource();
	}

	public override bool Equals(object? obj)
	{
		if (obj is Resource other)
		{
			return HeartwoodAmount == other.HeartwoodAmount &&
				   BarkOreAmount == other.BarkOreAmount &&
				   BloodSapAmount == other.BloodSapAmount;
		}
		return false;
	}
	public override int GetHashCode()
	{
		return HashCode.Combine(HeartwoodAmount, BarkOreAmount, BloodSapAmount);
	}
}
