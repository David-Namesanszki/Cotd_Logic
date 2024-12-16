namespace Cotd_Logic.Models.Buffs;

public enum BuffTypes
{
    HealthBuff,
    DamageBuff,
    ArmorBuff,
    TurnsToFormationBuff
}
public class Buff
{
    public BuffTypes BuffType { get; set; }
    public int Amount { get; set; }
    public int Duration { get; set; }
}
