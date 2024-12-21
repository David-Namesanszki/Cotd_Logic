using Cotd_Logic.Models.Captains;

namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics.UnlockingSystem;

public class CaptainUnlocker
{
    private readonly IList<Captain> _allCaptains;
    private readonly Random _random;

    public CaptainUnlocker(IList<Captain> allCaptains, Random random)
    {
        _allCaptains = allCaptains;
        _random = random;
    }

    public Captain UnlockRandomCaptain(IList<Captain> unlockedCaptains)
    {
        IList<Captain> notOwnedCaptains = _allCaptains.Except(unlockedCaptains).ToList();

        int randomIdx = _random.Next(notOwnedCaptains.Count);

        Captain randomCaptain = notOwnedCaptains[randomIdx];

		unlockedCaptains.Add(randomCaptain);

        return randomCaptain;
	}
}
