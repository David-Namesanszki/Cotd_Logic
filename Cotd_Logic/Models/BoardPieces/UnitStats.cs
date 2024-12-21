using Cotd_Logic.BL.GameLogic.Behaviours;

namespace Cotd_Logic.Models.BoardPieces;

public class UnitStats
{
	public int Health { get; set; }
	public int Power { get; set; }
	public int Armor { get; set; }
	public int TurnsToFormation { get; set; }
	public DamageTypes DamageType { get; set; }
}
