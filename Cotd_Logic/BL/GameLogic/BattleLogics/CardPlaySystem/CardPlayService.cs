using Cotd_Logic._Interfaces;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.CardPlaySystem;

public class CardPlayService : ICardPlayService
{
    private readonly IEffectHandler _effectHandler;

    public void PlayCard(Card card, IList<ITargetable?> targets)
    {
		if (card == null) throw new ArgumentNullException(nameof(card));

		// Handle null targets gracefully
		targets ??= new List<ITargetable?>(new ITargetable?[card.Effects.Count]);

		if (card.Effects.Count != targets.Count)
		{
			throw new ArgumentException(
				$"Mismatch between the number of card effects ({card.Effects.Count}) and provided targets ({targets.Count}).",
				nameof(targets));
		}

		for (int i = 0; i < card.Effects.Count; i++)
		{
			var effect = card.Effects[i];
			var target = targets[i];

			// Handle the effect
			_effectHandler.HandleEffect(effect, target);
		}
	}
}
