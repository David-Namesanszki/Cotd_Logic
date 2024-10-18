using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.DataAccessors.CardAccessors;

public class CommandCardAccessor
{
    private readonly ICommandCardRepository _repo;

    public CommandCardAccessor(ICommandCardRepository repo)
    {
        _repo = repo;
    }

    public CommandCard GetCard(int id)
    {
        CommandCardData data = _repo.GetOne(id);

        return new CommandCard(data);
    }

    public List<CommandCard> GetCards()
    {
        return _repo.GetAll()
                    .Select(data => new CommandCard(data))
                    .ToList();
    }
}
