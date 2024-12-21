namespace Cotd_Logic.BL.GameLogic.RaidLogics.DayPassSystem;

public class DayPassService : IDayPassService
{
	public DayPassService(int totalDays)
	{
		TotalDays = totalDays;
		RemainingDays = TotalDays;
	}

	public int TotalDays { get; private set; }
	public int RemainingDays { get; private set; }
	public bool OutOfDays => RemainingDays >= TotalDays;

	public void PassDays(int amount)
	{
		RemainingDays += amount;
	}
}
