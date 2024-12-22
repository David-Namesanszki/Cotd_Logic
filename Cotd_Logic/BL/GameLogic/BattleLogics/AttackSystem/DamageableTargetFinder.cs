using Cotd_Logic._Interfaces.AttackSystem;
using Cotd_Logic.BL.GameLogic.BattleLogics._Interfaces.Behaviours;
using Cotd_Logic.Models;
using Cotd_Logic.Models.BoardPieces;
using Cotd_Logic.Models.BoardTiles;

namespace Cotd_Logic.BL.GameLogic.BattleLogics.AttackSystem;

public class AttackTargetFinder : IAttackTargetFinder
{
    private readonly Board _board;

    public IDamageable? FindAttackTarget(IAttacker damager)
    {
        List<BoardPiece> redBoardPiecesInRow =
            _board.GetRedBoardPiecesInOneRow(damager.BoardTile.Row);

        // Check if the attack can hit
        if (!WillAttackHit(damager, redBoardPiecesInRow))
            return null;

        // Prioritize red pieces with frontside orientation
        var damageableTarget = redBoardPiecesInRow
            .Where(piece => piece.BoardTile.Orientation == BoardTileOrientation.Frontside)
            .OfType<IDamageable>()
            .FirstOrDefault();

        if (damageableTarget != null)
            return damageableTarget;

        // Fallback to first damageable target with backside orientation
        return redBoardPiecesInRow
            .Where(piece => piece.BoardTile.Orientation == BoardTileOrientation.Backside)
            .OfType<IDamageable>()
            .FirstOrDefault();
    }

    private bool WillAttackHit(IAttacker damager, List<BoardPiece> redBoardPiecesInSameRow)
    {
        // Check conditions that prevent the attack from hitting
        bool isMeleeOnBackside = damager.DamageType == DamageTypes.Melee &&
                                 damager.BoardTile.Orientation == BoardTileOrientation.Backside;

        bool noRedTargets = redBoardPiecesInSameRow.Count == 0 && _board.RedCaptain == null;

        return !(isMeleeOnBackside || noRedTargets);
    }
}
