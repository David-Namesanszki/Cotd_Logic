namespace Cotd_Logic.BL.GameLogic.RaidLogics.DayPassSystem;

public class DayPassService : IDayPassService
{
	public DayPassService(int totalDays)
	{
		TotalDays = totalDays;
	}

	public int TotalDays { get; private set; }
	public int RemainingDays { get; private set; }

	public void PassDays(int amount)
	{
		RemainingDays += amount;
	}

	public bool OutOfDays()
	{
		return RemainingDays >= TotalDays;
	}
}
