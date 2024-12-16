using Cotd_Data.ValueObjects;
using Cotd_Logic.Models.Locations;
using System;

namespace Cotd_Logic.BL.GameLogic.BattleLogics;

public delegate void BattlFinishedEventHandler(bool success, Loot loot);
public class BattleLogic
{
    private Battle _currentBattle;

    public event BattlFinishedEventHandler BattleFinished;
}
