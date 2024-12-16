using Cotd_Data.ValueObjects;
using Cotd_Logic._Interfaces;

namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics.UnlockingSystem;

public class ResourcePurchaser : IPurchaser<Loot>
{
    private Loot _playerResources;

    public ResourcePurchaser(Loot playerResources)
    {
        _playerResources = playerResources;
    }

    public bool IsPurchasable(Loot cost)
    {
        return cost < _playerResources;
    }

    public void Purchase(Loot cost)
    {
        if (IsPurchasable(cost))
        {
            _playerResources -= cost;
        }
    }
}
