using Cotd_Data.ValueObjects;
using Cotd_Logic._Interfaces;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Services;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Validators;
using Cotd_Logic.BL.GameLogic.RiftBaseLogics.ContainerSystem;
using Cotd_Logic.Models;
using Cotd_Logic.Models.BoardPieces;
using Cotd_Logic.Models.Cards;
using System;

namespace Cotd_Logic.BL.GameLogic.BattleLogics;

public delegate void BattleFinishedEventHandler(bool success, Loot loot);
public class BattleLogic
{
    private Battle _currentBattle;

    public event BattleFinishedEventHandler BattleFinished;

    private readonly IAttackService _attackService;
	private readonly IRiftBaseProvider _riftBaseProvider;
	private readonly IAttackValidator _attackValidator;
	private readonly ICardPlayService _cardPlayService;

	public void AttackWith(string riftBaseId, string boardPieceId)
    {
        Battle battle = GetBattle(riftBaseId);

		BoardPiece boardPiece = battle.Board.GetBlueBoardPiece(boardPieceId);

		if (boardPiece is not IAttacker attacker)
		{
			throw new ArgumentException("The specified board piece is not an attacker.");
		}

		_attackService.AttackWith(attacker);
	}

	public void PlayCard(string riftBaseId, string cardId, string? targetId = null)
	{
		RiftBase riftBase = _riftBaseProvider.GetRiftBase(riftBaseId);

		Card card = riftBase.UnlockedCards.FirstOrDefault(card => card.Id == cardId);

		

		_cardPlayService.PlayCard(card,);
	}

	private Battle GetBattle(string riftBaseId)
	{
		RiftBase riftBase = _riftBaseProvider.GetRiftBase(riftBaseId);

		if (riftBase.OngoingRaid == null)
		{
			throw new ArgumentNullException("There is no ongoing raid for this rift base");
		}

		if (riftBase.OngoingRaid.OngoingBattle == null)
		{
			throw new ArgumentNullException("There is no ongoing battle for this raid");
		}

		return riftBase.OngoingRaid.OngoingBattle;
	}
}
