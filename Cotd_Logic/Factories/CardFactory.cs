using Cotd_Data.Repositories.CardRepositories;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.DataAccessors.CardAccessors;
using Cotd_Logic.Models.Cards;
using Cotd_Logic.DataAccessors.Interfaces;
using Cotd_Data.Models;
using Cotd_Data.Repositories.GameInfoRepositories;
using Cotd_Logic.DataStorage.Interfaces;
using Cotd_Logic.DataStorage.GameInfoStorages;
using Cotd_Logic.DataAccessors.GameInfoAccessors;
using Cotd_Logic.Models.GameInfos;

namespace Godot;

public static class CardFactory
{
    public static IDataAccessor<CommandCard> CommandCardAccessor { get; set; }
	public static IDataAccessor<ConstructionCard> ConstructionCardAccessor { get; set; }
	public static IDataAccessor<DreamCard> DreamCardAccessor { get; set; }
	public static IDataAccessor<FireCard> FireCardAccessor { get; set; }
	public static IDataAccessor<UnitCard> UnitCardAccessor { get; set; }
    public static IDataAccessor<WeatherCard> WeatherCardAccessor { get; set; }
	public static IDataAccessor<Game> GameInfoAccessor { get; set; }


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
