using Cotd_Logic._Interfaces;
using Cotd_Logic.BL.GameLogic.BattleLogics.CardPlaySystem;
using Cotd_Logic.BL.GameLogic.RaidLogics;
using Cotd_Logic.BL.GameLogic.RiftBaseLogics.RaidEndingSystem;
using Cotd_Logic.BL.GameLogic.RiftBaseLogics.RaidStartingSystem;
using Cotd_Logic.Models;
using Cotd_Logic.Models.Captains;
using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.Enemies;
using Cotd_Logic.Models.Locations;
using Cotd_Logic.Models.Maps;

namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics;

public class RiftBaseLogic
{
    private IDataAccessor<RiftBase> _gameAccessor;
    private IDataStorage<RiftBase> _gameStorage;
    private IDataAccessor<Captain> _captainAccessor;
    private IDataAccessor<Card> _cardAccessor;
    private IDataAccessor<Enemy> _enemyAccessor;

    private readonly ICaptainUnlocker _captainUnlocker;
    private readonly ICardUnlocker _cardUnlocker;
    private readonly IRiftBaseProvider _riftBaseProvider;

	public void LoadGame(string riftBaseId)
    {
        RiftBase riftBase = _gameAccessor.GetOne(riftBaseId);

        _riftBaseProvider.SetRiftBase(riftBaseId, riftBase);
	}

    public void NewGame(string name)
    {
		RiftBase riftBase = new RiftBase(name);
        string id = Guid.NewGuid().ToString();

		_riftBaseProvider.SetRiftBase(id, riftBase);

		_gameStorage.Save(riftBase);
    }

    public void SaveGame(string riftBaseId)
    {
		RiftBase riftBase = _gameAccessor.GetOne(riftBaseId);

		_gameStorage.Update(riftBase);
    }

    public Card UnlockCard(CardTypes cardType)
    {
        return _cardUnlocker.UnlockRandomCard(cardType);
    }

    public Captain UnlockCaptain()
    {
        return _captainUnlocker.UnlockRandomCaptain();
    }

}
