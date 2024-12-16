using Cotd_Data.Models.Cards.Effects;

namespace Cotd_Logic.Models.Effects;

public enum EffectTypes
{
    DrawCard,
    DealDamage,
    ArmorUp,
    Heal,
    Undefined
}
public class Effect
{
    public Effect()
    {
    }

    public Effect(EffectData data)
    {
        EffectType = (EffectTypes)data.EffectType;
        Parameter = data.Parameter;
    }

    public Effect(EffectTypes effectType, int? parameter = null)
    {
        Parameter = parameter;
        EffectType = effectType;
    }

    public int? Parameter { get; set; } = null;
    public EffectTypes EffectType { get; set; } = EffectTypes.Undefined;

    public EffectData ToData()
    {
        return new EffectData()
        {
            EffectType = (Cotd_Data.Models.Cards.Effects.EffectTypes)EffectType,
            Parameter = Parameter,
        };
    }
}
