namespace Cotd_Logic.Models.Cards;

public enum UnitTypes
{
    Melee,
    Ranged,
    Support
}

public class UnitCard : Card
{
    public int TurnsToFormation { get; set; }
    public int Health { get; set; }
    public int Power { get; set; }
    public int Armor { get; set; }
    public UnitTypes Type { get; set; }
}
