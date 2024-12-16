using Cotd_Logic.BL.Behaviours;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.Models.BoardPieces;

public enum UnitTypes
{
    Melee,
    Ranged,
    Support
}
public class Unit : BoardPiece
{
    private UnitCard _card;

    public Unit(UnitCard card)
    {
        _card = card;
        Name = card.Name;
        Health = card.Health;
        Power = card.Power;
        Armor = card.Armor;
        TurnsToFormation = card.TurnsToFormation;
        Image = card.Image;
    }

    public Unit(string name, string image, int health, int power, int armor, int turnsToFormation)
    {
        _card = new UnitCard();
        Name = name;
        Image = image;
        Health = health;
        Power = power;
        Armor = armor;
        TurnsToFormation = turnsToFormation;
    }

    public string Name { get; set; }
    public string Image { get; set; } = string.Empty;
    public int Health { get; set; }
    public int Power { get; set; }
    public int Armor { get; set; }
    public UnitTypes UnitType { get; set; }
    public int TurnsToFormation { get; set; }
    public bool IsInFormation => TurnsToFormation <= 0;
    public bool HasAttacked { get; set; } = false;
    public event Action? DestroyArmor;
    public event Action? Attack;

    public void OnStartTurn()
    {
        if (!IsInFormation)
        {
            TurnsToFormation -= 1;
        }

        HasAttacked = false;
    }

    public void TakeDamage(int damage, bool bypassArmor = false)
    {
        if (bypassArmor)
        {
            Health = Math.Max(0, Health - damage);
        }
        else
        {
            // Reduce armor first
            int reducedArmor = Math.Max(0, Armor - damage);

            // Calculate remaining damage after armor
            int effectiveDamage = Math.Max(0, damage - Armor);

            // Apply remaining damage to health
            Health = Math.Max(0, Health - effectiveDamage);

            // Update the current armor value
            Armor = reducedArmor;
        }

        if (Armor <= 0)
        {
            DestroyArmor?.Invoke();
        }

        if (Health <= 0)
        {
            OnDestroyed();
        }
    }

    public UnitCard ToCard()
    {
        return new UnitCard()
        {
            Image = Image,
            Power = Power,
            Health = Health,
            Armor = Armor,
            TurnsToFormation = _card.TurnsToFormation,
            Description = _card.Description,
            Effects = _card.Effects,
            EnvoyCost = _card.EnvoyCost,
            Id = _card.Id,
            CardType = _card.CardType,
            Name = _card.Name,
        };
    }
}
