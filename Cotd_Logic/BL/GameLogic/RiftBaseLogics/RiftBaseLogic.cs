using Cotd_Logic._Interfaces;
using Cotd_Logic.BL.GameLogic.BattleLogics.CardPlaySystem;
using Cotd_Logic.Models;
using Cotd_Logic.Models.Captains;
using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.Enemies;
using Cotd_Logic.Models.Locations;
using Cotd_Logic.Models.Maps;

namespace Cotd_Logic.BL.GameLogic.RiftBaseLogics;

public class RiftBaseLogic
{
    private RiftBase _currentRiftBase;

    private IDataAccessor<RiftBase> _gameAccessor;
    private IDataStorage<RiftBase> _gameStorage;
    private IDataAccessor<Captain> _captainAccessor;
    private IDataAccessor<Card> _cardAccessor;
    private IDataAccessor<Enemy> _enemyAccessor;
    private ICardPlayService _cardPlayService;

    ICaptainUnlocker _captainUnlocker;
    ICardUnlocker _cardUnlocker;

    public void LoadGame(string gameId)
    {
        _currentRiftBase = _gameAccessor.GetOne(gameId);
    }

    public void NewGame(string name)
    {
        _currentRiftBase = new RiftBase(name);
        _gameStorage.Save(_currentRiftBase);
    }

    public void SaveGame()
    {
        _gameStorage.Update(_currentRiftBase);
    }

    public void UnlockCard(CardTypes cardType)
    {
        _cardUnlocker.UnlockRandomCard(cardType);
    }

    public void UnlockCaptain()
    {
        _captainUnlocker.UnlockRandomCaptain();
    }

    public void StartRaid(string captainId)
    {
        Captain captain = _captainAccessor.GetOne(captainId);
        Map map = new Map();

        _currentRiftBase.OngoingRaid = new Raid(captain, map);
    }

    public Location HandleLocation(string locationId)
    {
        return _currentRiftBase.OngoingRaid?.Map.GetLocation(locationId)
            ?? throw new ArgumentNullException("There is no ongoing raid");
    }

    public void PlayCard(string cardId)
    {
        Card card = _cardAccessor.GetOne(cardId);

        _cardPlayService.PlayCard(card);
    }

    public void EndTurn()
    {

    }
}
