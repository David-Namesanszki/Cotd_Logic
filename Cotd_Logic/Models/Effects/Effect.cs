namespace Cotd_Logic.Models.Effects;

public enum EffectTypes
{
    DrawCard,
    DealDamage,
    ArmorUp,
    Heal
}
public class Effect
{
    public int Parameter { get; set; }
    public EffectTypes Type { get; set; }
}
