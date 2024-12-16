using Cotd_Logic.Models.Buffs;

namespace Cotd_Logic.BL.GameLogic.Behaviours;

public interface IBuffable
{
    IList<Buff> Buffs { get; set; }
}
