using Cotd_Data._Interfaces;
using Cotd_Data.Models.Enemies;
using Cotd_Logic._Interfaces;
using Cotd_Logic.Models.Enemies;

namespace Cotd_Logic.BL.DataAccessors;

public class EnemyAccessors : IDataAccessor<Enemy>
{
    private readonly IEnemyRepository _repo;

    public EnemyAccessors(IEnemyRepository repo)
    {
        _repo = repo;
    }

    public List<Enemy> GetAll()
    {
        return _repo.GetAll().Select(x => new Enemy(x)).ToList();
    }

    public Enemy GetOne(string id)
    {
        EnemyData data = _repo.GetOne(id);

        return new Enemy(data);
    }
}
