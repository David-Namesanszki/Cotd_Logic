using Cotd_Logic._Interfaces;

namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics.UnlockingSystem;

public class LevelPurchaser : IPurchaser<int>
{
    private int _playerLevel;

    public LevelPurchaser(int playerLevel)
    {
        _playerLevel = playerLevel;
    }

    public bool IsPurchasable(int cost)
    {
        return cost < _playerLevel;
    }

    public void Purchase(int cost)
    {
        if (IsPurchasable(cost))
        {
            _playerLevel -= cost;
        }
    }
}
