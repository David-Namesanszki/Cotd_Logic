using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.DataAccessors.Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.DataAccessors.CardAccessors;

public class WeatherCardAccessor : IDataAccessor<WeatherCard>
{
    private readonly IWeatherCardRepository _repo;

    public WeatherCardAccessor(IWeatherCardRepository weatherCardRepository)
    {
        _repo = weatherCardRepository;
    }

    public WeatherCard GetOne(string id)
    {
        WeatherCardData data = _repo.GetOne(id);

        return new WeatherCard(data);
    }

    public List<WeatherCard> GetAll()
    {
        return _repo.GetAll()
                    .Select(data => new WeatherCard(data))
                    .ToList();
    }
}
