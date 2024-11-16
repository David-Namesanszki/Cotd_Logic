namespace Cotd_Logic.BL._Interfaces;

public interface IDataStorage<T>
{
    void Save(T entity);
    void Delete(T entity);
    void Update(T entity);
}
