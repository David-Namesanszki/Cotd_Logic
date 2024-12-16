namespace Cotd_Logic._Interfaces
{
    public interface IDataAccessor<T>
    {
        T GetOne(string id);
        List<T> GetAll();
    }
}