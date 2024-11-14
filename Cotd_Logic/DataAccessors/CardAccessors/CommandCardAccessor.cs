using Cotd_Data.Models.Cards;
using Cotd_Data.Repositories.CardRepositories.Interfaces;
using Cotd_Logic.DataAccessors.Interfaces;
using Cotd_Logic.Models.Cards;

namespace Cotd_Logic.DataAccessors.CardAccessors;

public class CommandCardAccessor : IDataAccessor<CommandCard>
{
    private readonly ICommandCardRepository _repo;

    public CommandCardAccessor(ICommandCardRepository repo)
    {
        _repo = repo;
    }

    public CommandCard GetOne(string id)
    {
        CommandCardData data = _repo.GetOne(id);

        return new CommandCard(data);
    }

    public List<CommandCard> GetAll()
    {
        return _repo.GetAll()
                    .Select(data => new CommandCard(data))
                    .ToList();
    }
}
