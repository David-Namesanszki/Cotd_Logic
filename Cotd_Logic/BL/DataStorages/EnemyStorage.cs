using Cotd_Data._Interfaces;
using Cotd_Logic.BL._Interfaces;
using Cotd_Logic.Models.Enemies;

namespace Cotd_Logic.BL.DataStorages;

public class EnemyStorage : IDataStorage<Enemy>
{
    private readonly IEnemyRepository _repo;

    public EnemyStorage(IEnemyRepository repo)
    {
        _repo = repo;
    }

    public void Delete(Enemy entity)
    {
        _repo.Remove(entity.ToData());
    }

    public void Save(Enemy entity)
    {
        _repo.Insert(entity.ToData());
    }

    public void Update(Enemy data)
    {
        _repo.Update(data.ToData());
    }
}
