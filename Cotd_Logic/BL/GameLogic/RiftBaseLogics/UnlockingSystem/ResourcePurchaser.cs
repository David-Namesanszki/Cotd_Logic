using Cotd_Data.ValueObjects;

namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics.UnlockingSystem;

public class ResourcePurchaser
{
    public bool IsPurchasable(Loot playerLoot, Loot cost)
    {
        return cost < playerLoot;
    }

    public void Purchase(ref Loot playerLoot, Loot cost)
    {
        if (IsPurchasable(playerLoot, cost))
        {
			playerLoot -= cost;
        }
    }
}
