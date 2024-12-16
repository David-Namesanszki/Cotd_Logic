using Cotd_Data.Models.Captains;
using Cotd_Data.Repositories;
using Cotd_Logic._Interfaces;
using Cotd_Logic.Models.Captains;

namespace Cotd_Logic.BL.DataAccessors;

public class CaptainAccessor : IDataAccessor<Captain>
{
    private readonly CaptainRepository _repo;

    public CaptainAccessor(CaptainRepository repo)
    {
        _repo = repo;
    }

    public List<Captain> GetAll()
    {
        return _repo.GetAll().Select(c => new Captain(c)).ToList();
    }

    public Captain GetOne(string id)
    {
        CaptainData data = _repo.GetOne(id);

        return new Captain(data);
    }
}
