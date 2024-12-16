using Cotd_Logic._Interfaces;
using Cotd_Logic.Models.Captains;

namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics.UnlockingSystem;

public class CaptainUnlocker : ICaptainUnlocker
{
    private readonly IList<Captain> _allCaptains;
    private readonly IList<string> _ownedCaptainIds;
    private readonly Random _random;

    public CaptainUnlocker(IList<Captain> allCaptains, IList<string> ownedCaptainIds, Random random)
    {
        _allCaptains = allCaptains;
        _ownedCaptainIds = ownedCaptainIds;
        _random = random;
    }

    public Captain UnlockRandomCaptain()
    {
        IList<string> notOwnedCaptains = _allCaptains.Select(c => c.Id).Except(_ownedCaptainIds).ToList();

        int randomIdx = _random.Next(notOwnedCaptains.Count);

        string randomCardId = notOwnedCaptains[randomIdx];

        return _allCaptains.FirstOrDefault(c => c.Id == randomCardId) ?? throw new KeyNotFoundException($"Card with ID {randomCardId} not found."); ;
    }
}
