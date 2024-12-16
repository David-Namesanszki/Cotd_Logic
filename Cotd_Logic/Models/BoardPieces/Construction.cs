using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.Models.BoardPieces;

public class Construction : BoardPiece
{
    private ConstructionCard _card;

    public Construction(ConstructionCard card)
    {
        _card = card;
        Power = card.Power;
        Armor = card.Armor;
        TurnsToBuild = card.TurnsToBuild;
        Image = card.Image;
    }

    public string Image { get; set; } = string.Empty;
    public int Power { get; set; }
    public int Armor { get; set; }
    public int TurnsToBuild { get; set; }
    public bool IsBuilt => TurnsToBuild == 0;

    public void OnEndTurn()
    {
        if (!IsBuilt)
        {
            TurnsToBuild -= 1;
        }
    }

    public ConstructionCard ToCard()
    {
        return new ConstructionCard()
        {
            Image = Image,
            Power = Power,
            Armor = Armor,
            TurnsToBuild = _card.TurnsToBuild,
            Description = _card.Description,
            Effects = _card.Effects,
            EnvoyCost = _card.EnvoyCost,
            Id = _card.Id,
            CardType = _card.CardType,
            Name = _card.Name,
        };
    }
}
