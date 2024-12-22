using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.Models.Buffs;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.BuffingSystem;

public delegate void Buffed(IBuffable buffable, Buff buff);
public class BuffingService
{
    public event Buffed? Buffed;
    public void Buff(IBuffable buffable, Buff buff)
    {
        buffable.Buffs.Add(buff);

        Buffed?.Invoke(buffable, buff);
    }
}
