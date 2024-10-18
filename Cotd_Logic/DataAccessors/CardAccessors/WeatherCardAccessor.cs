using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.DataAccessors.CardAccessors;

public class WeatherCardAccessor : ICardAccessor<WeatherCard>
{
    private readonly IWeatherCardRepository _repo;

    public WeatherCardAccessor(IWeatherCardRepository weatherCardRepository)
    {
        _repo = weatherCardRepository;
    }

    public WeatherCard GetCard(int id)
    {
        WeatherCardData data = _repo.GetOne(id);

        return new WeatherCard(data);
    }

    public List<WeatherCard> GetCards()
    {
        return _repo.GetAll()
                    .Select(data => new WeatherCard(data))
                    .ToList();
    }
}
