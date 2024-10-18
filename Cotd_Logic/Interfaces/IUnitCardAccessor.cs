namespace Cotd_Logic.Interfaces
{
    public interface ICardAccessor<T>
    {
        T GetCard(int id);
        List<T> GetCards();
    }
}