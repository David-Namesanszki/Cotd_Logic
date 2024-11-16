using Cotd_Logic.Models.Effects;
using System.Net.Http.Headers;

namespace Cotd_Logic.BL;

public class EffectHandler
{
	public void HandleEffect(EffectTypes effectType, int parameter)
	{
		switch (effectType)
		{
			case EffectTypes.DrawCard:
				break;
			case EffectTypes.DealDamage:
				break;
			case EffectTypes.ArmorUp:
				break;
			case EffectTypes.Heal:
				break;
			default:
				break;
		}
	}
}
