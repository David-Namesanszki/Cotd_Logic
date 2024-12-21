using Cotd_Logic.Models.BoardTiles;
using Cotd_Logic.Models.Buffs;

namespace Cotd_Logic.Models.BoardPieces;

public class Construction : BoardPiece
{
	public Construction(
		string name,
        string image,
		IList<Buff> buffs,
		BoardTile boardTile,
		ConstructionStats stats
	) : base(name, image, buffs, boardTile)
	{
        Stats = stats;
	}

    ConstructionStats Stats { get; set; }
    public bool IsInFormation => Stats.TurnsToFormation <= 0;

    //public ConstructionCard ToCard()
    //{
    //    return new ConstructionCard()
    //    {
    //        Image = Image,
    //        Power = Power,
    //        Armor = Armor,
    //        TurnsToBuild = _card.TurnsToBuild,
    //        Description = _card.Description,
    //        Effects = _card.Effects,
    //        EnvoyCost = _card.EnvoyCost,
    //        Id = _card.Id,
    //        CardType = _card.CardType,
    //        Name = _card.Name,
    //    };
    //}
}
