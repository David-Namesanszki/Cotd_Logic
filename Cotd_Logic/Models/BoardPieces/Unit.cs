using Cotd_Logic.BL.GameLogic.Behaviours;
using Cotd_Logic.Models.BoardTiles;
using Cotd_Logic.Models.Buffs;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.Models.BoardPieces;

public enum UnitTypes
{
    Melee,
    Ranged,
    Support
}
public class Unit : BoardPiece, IAttacker
{
	public Unit(string name, string image, IList<Buff> buffs, BoardTile boardTile) : base(name, image, buffs, boardTile)
	{
	}

    public bool IsInFormation => Stats.TurnsToFormation <= 0;
    public bool HasAttacked { get; set; } = false;
    public UnitStats Stats { get; set; }

    public event Action? DestroyArmor;
    public event Action? Attack;

    public void OnStartTurn()
    {
        if (!IsInFormation)
        {
			Stats.TurnsToFormation -= 1;
        }

        HasAttacked = false;
    }

    public void TakeDamage(int damage, bool bypassArmor = false)
    {
        if (bypassArmor)
        {
			Stats.Health = Math.Max(0, Stats.Health - damage);
        }
        else
        {
            // Reduce armor first
            int reducedArmor = Math.Max(0, Stats.Armor - damage);

            // Calculate remaining damage after armor
            int effectiveDamage = Math.Max(0, damage - Stats.Armor);

			// Apply remaining damage to health
			Stats.Health = Math.Max(0, Stats.Health - effectiveDamage);

			// Update the current armor value
			Stats.Armor = reducedArmor;
        }

        if (Stats.Armor <= 0)
        {
            DestroyArmor?.Invoke();
        }

        if (Stats.Health <= 0)
        {
            OnDestroyed();
        }
    }

    //public UnitCard ToCard()
    //{
    //    return new UnitCard()
    //    {
    //        Image = Image,
    //        Power = Power,
    //        Health = Health,
    //        Armor = Armor,
    //        TurnsToFormation = _card.TurnsToFormation,
    //        Description = _card.Description,
    //        Effects = _card.Effects,
    //        EnvoyCost = _card.EnvoyCost,
    //        Id = _card.Id,
    //        CardType = _card.CardType,
    //        Name = _card.Name,
    //    };
    //}
}
