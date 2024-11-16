using Cotd_Logic.Models.Cards;
using Cotd_Logic.Models.GameInfos;
using Cotd_Logic.BL._Interfaces;
using Cotd_Logic.BL.DataAccessors;
using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories;
using Cotd_Data._Interfaces;

namespace Cotd_Logic.BL.Factories;

public static class CardFactory
{
    public static ICardRepository CardRepository { get; set; } = new CardRepository("");
    public static IDataAccessor<Card> CardAccessor { get; set; } = new CardAccessor(CardRepository);

    public static void Init()
    {
        //CardsDbContext ctx = new CardsDbContext();

        //ICommandCardRepository _commandCardRepo = new CommandCardRepository(ctx);
        //IConstructionCardRepository _constructionCardRepo = new ConstructionCardRepository(ctx);
        //IDreamCardRepository _dreamCardRepo = new DreamCardRepository(ctx);
        //IFireCardRepository _fireCardRepo = new FireCardRepository(ctx);
        //IUnitCardRepository _unitCardRepo = new UnitCardRepository(ctx);
        //IWeatherCardRepository _weatherCardRepo = new WeatherCardRepository(ctx);
        //IGameInfoRepository gameInfoRepository = new GameInfoRepository(ctx);

        //GameInfoAccessor = new GameInfoAccessor(gameInfoRepository);
        //CommandCardAccessor = new CommandCardAccessor(_commandCardRepo);
        //ConstructionCardAccessor = new ConstructionCardAccessor(_constructionCardRepo);
        //DreamCardAccessor = new DreamCardAccessor(_dreamCardRepo);
        //FireCardAccessor = new FireCardAccessor(_fireCardRepo);
        //UnitCardAccessor = new UnitCardAccessor(_unitCardRepo);
        //WeatherCardAccessor = new WeatherCardAccessor(_weatherCardRepo);
    }
}
