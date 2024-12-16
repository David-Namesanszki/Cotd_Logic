using Cotd_Data._Interfaces;
using Cotd_Logic._Interfaces;
using Cotd_Logic.Models.Captains;

namespace Cotd_Logic.BL.DataStorages;

public class CaptainStorage : IDataStorage<Captain>
{
    private readonly ICaptainRepository _repo;

    public CaptainStorage(ICaptainRepository repo)
    {
        _repo = repo;
    }

    public void Delete(Captain entity)
    {
        _repo.Remove(entity.ToData());
    }

    public void Save(Captain entity)
    {
        _repo.Insert(entity.ToData());
    }

    public void Update(Captain entity)
    {
        _repo.Update(entity.ToData());
    }
}
