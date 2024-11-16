namespace Cotd_Logic.BL._Interfaces
{
    public interface IDataAccessor<T>
    {
        T GetOne(string id);
        List<T> GetAll();
    }
}