using Cotd_Data.Models.Boards;
using Cotd_Data.Models.Maps.Locations;
using Cotd_Logic.Models.BoardPieces;
using Cotd_Logic.Models.BoardTiles;
using Cotd_Logic.Models.Captains;
using Cotd_Logic.Models.Maps.Locations;
using System.Security.Cryptography;

namespace Cotd_Logic.Models;

public class Board
{

    public Board(BoardData data)
    {

    }

    public List<BoardTile> RedBoardTiles { get; set; }
    public List<BoardPiece> RedBoardPieces { get; set; } = [];
    public Captain? RedCaptain { get; set; }

    public List<BoardTile> BlueBoardTiles { get; set; }
    public List<BoardPiece> BlueBoardPieces { get; set; } = [];
    public Captain? BlueCaptain { get; set; }

    public BoardPiece GetRedBoardPiece(string boardPieceId)
    {
        return RedBoardPieces.FirstOrDefault(p => p.Id == boardPieceId)
            ?? throw new KeyNotFoundException($"There is no boardpiece with this id: {boardPieceId}");
    }

    public BoardTile? GetBoardTile(BoardPiece boardPiece)
    {
        return BlueBoardTiles.FirstOrDefault(t => t.BoardPiece == boardPiece);
    }

    public BoardPiece GetBlueBoardPiece(string boardPieceId)
    {
        return BlueBoardPieces.FirstOrDefault(p => p.Id == boardPieceId)
            ?? throw new KeyNotFoundException($"There is no boardpiece with this id: {boardPieceId}");
    }

    public BoardTile GetRedBoardTile(string boardTileId)
    {
        return RedBoardTiles.FirstOrDefault(p => p.Id == boardTileId)
            ?? throw new KeyNotFoundException($"There is no boardtile with this id: {boardTileId}");
    }

    public BoardTile GetBlueBoardTile(string boardTileId)
    {
        return BlueBoardTiles.FirstOrDefault(p => p.Id == boardTileId)
            ?? throw new KeyNotFoundException($"There is no boardtile with this id: {boardTileId}");
    }

    public List<BoardTile> GetRedBoardTilesInOneRow(int row)
    {
        return RedBoardTiles.Where(p => p.Row == row).ToList();
    }

    public List<BoardPiece> GetRedBoardPiecesInOneRow(int row)
    {
        return RedBoardPieces.Where(p => p.BoardTile.Row == row).ToList();
    }

    public List<BoardPiece> GetBlueBoardPiecesInOneRow(int row)
    {
        return BlueBoardPieces.Where(p => p.BoardTile.Row == row).ToList();
    }

    //private Location CreateBoardTile(BoardTile boardTile)
    //{
    //	return boardTile. switch
    //	{
    //		Cotd_Data.Models.Maps.Locations.LocationTypes.Altar => new Altar(locationData as AltarData ?? throw new InvalidCastException("Invalid AltarData")),
    //		Cotd_Data.Models.Maps.Locations.LocationTypes.Battle => new Battle(locationData as BattleData ?? throw new InvalidCastException("Invalid BattleData")),
    //		Cotd_Data.Models.Maps.Locations.LocationTypes.HarvestingSite => new HarvestingSite(locationData as HarvestingSiteData ?? throw new InvalidCastException("Invalid HarvestingSiteData")),
    //		Cotd_Data.Models.Maps.Locations.LocationTypes.RecruitmentCamp => new RecruitmentCamp(locationData as RecruitmentCampData ?? throw new InvalidCastException("Invalid RecruitmentCampData")),
    //		Cotd_Data.Models.Maps.Locations.LocationTypes.Start => new StartLocation(locationData as StartLocationData ?? throw new InvalidCastException("Invalid StartLocationData")),
    //		Cotd_Data.Models.Maps.Locations.LocationTypes.End => new EndLocation(locationData as EndLocationData ?? throw new InvalidCastException("Invalid EndLocationData")),
    //		Cotd_Data.Models.Maps.Locations.LocationTypes.Undefined => throw new ArgumentException("Location type is undefined"),
    //		_ => throw new ArgumentException("Location type is unknown")
    //	};
    //}
}
