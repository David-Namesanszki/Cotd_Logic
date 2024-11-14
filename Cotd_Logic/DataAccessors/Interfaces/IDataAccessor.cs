namespace Cotd_Logic.DataAccessors.Interfaces
{
    public interface IDataAccessor<T>
    {
        T GetOne(string id);
        List<T> GetAll();
    }
}