using Cotd_Logic.Models.BoardTiles;

namespace Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

public enum DamageTypes
{
    Melee,
    Ranged,
}

public interface IAttacker
{
    int Power { get; set; }
    DamageTypes DamageType { get; set; }
    BoardTile BoardTile { get; set; }
    public bool CanAttack { get; set; }
}
