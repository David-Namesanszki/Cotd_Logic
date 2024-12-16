namespace Cotd_Logic.BL.GameLogic.RaidLogics.DayPassSystem
{
	public interface IDayPassService
	{
		int RemainingDays { get; }
		int TotalDays { get; }

		bool OutOfDays();
		void PassDays(int amount);
	}
}