using Cotd_Logic.Models.Buffs;

namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

public interface IBuffable
{
    IList<Buff> Buffs { get; set; }
}
