using Cotd_Data.Models.Cards.Effects;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;

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
    public Type? TargetType => GetTargetType(EffectType);

	public EffectData ToData()
    {
        return new EffectData()
        {
            EffectType = (Cotd_Data.Models.Cards.Effects.EffectTypes)EffectType,
            Parameter = Parameter,
        };
    }

	private Type? GetTargetType(EffectTypes effectType)
	{
		return effectType switch
		{
			EffectTypes.DrawCard => null,
			EffectTypes.DealDamage => typeof(IAttacker),
			EffectTypes.ArmorUp => typeof(IDefender),
			EffectTypes.Heal => typeof(IHealable),
			EffectTypes.Undefined => null,
			_ => throw new ArgumentOutOfRangeException(nameof(effectType), "Unhandled effect type")
		};
	}
}
