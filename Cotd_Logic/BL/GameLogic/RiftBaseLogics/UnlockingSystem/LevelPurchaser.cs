namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics.UnlockingSystem;

public class LevelPurchaser
{
    public bool IsPurchasable(int playerLevel, int cost)
    {
        return cost < playerLevel;
    }

    public void Purchase(ref int playerLevel, int cost)
    {
        if (IsPurchasable(playerLevel, cost))
        {
			playerLevel -= cost;
        }
    }
}
