using Cotd_Data.Models.Cards.Effects;
using Cotd_Logic._Interfaces.AttackSystem;
using Cotd_Logic._Interfaces.DefendSystem;
using Cotd_Logic._Interfaces.HealingSystem;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.RaidLogics;
using Cotd_Logic.Models;
using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.Effects;
using System.Collections.Generic;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.CardPlaySystem;

public class TargetProvider
{
	private readonly IBattleProvider _battleProvider;
	private readonly IValidAttackersProvider _validAttackersProvider;
	private readonly IValidDefendersProvider _validDefendersProvider;
	private readonly IValidHealablesProvider _validHealablesProvider;

	public IList<IList<ITargetable>> ProvideTargetForCard(string riftBaseId, Card card)
	{
		IList<IList<ITargetable>> targets = [];

		foreach (var effect in card.Effects)
		{
			switch (effect.TargetType)
			{
				case Type attacker when attacker == typeof(IAttacker):
					// Get attackers and cast to ITargetable
					var attackers = _validAttackersProvider
						.GetValidAttackers(_battleProvider.GetBattle(riftBaseId).Board.BlueBoardPieces)
						.Cast<ITargetable>() // Ensure proper type compatibility
						.ToList();

					// Add to the targets list
					targets.Add(attackers);
					break;

				case Type defender when defender == typeof(IDefender):
					// Get defenders and cast to ITargetable
					var defenders = _validDefendersProvider
						.GetValidDefenders(_battleProvider.GetBattle(riftBaseId).Board.BlueBoardPieces)
						.Cast<ITargetable>() // Ensure proper type compatibility
						.ToList();

					// Add to the targets list
					targets.Add(defenders);
					break;

				case Type healable when healable == typeof(IHealable):
					// Get healables and cast to ITargetable
					var healables = _validHealablesProvider
						.GetValidHealables(_battleProvider.GetBattle(riftBaseId).Board.BlueBoardPieces)
						.Cast<ITargetable>() // Ensure proper type compatibility
						.ToList();

					// Add to the targets list
					targets.Add(healables);
					break;

				case null:
					targets.Add(new List<ITargetable>()); // Effects that don't require a target
					break;

				default:
					throw new InvalidOperationException($"Unhandled target type: {effect.TargetType}");
			}
		}

		return targets;
	}
}
