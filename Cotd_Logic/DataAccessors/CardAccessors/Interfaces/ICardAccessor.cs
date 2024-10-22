namespace Cotd_Logic.DataAccessors.CardAccessors.Interfaces
{
    public interface ICardAccessor<T>
    {
        T GetCard(int id);
        List<T> GetCards();
    }
}