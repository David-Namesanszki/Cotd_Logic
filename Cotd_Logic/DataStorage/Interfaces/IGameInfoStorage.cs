namespace Cotd_Logic.DataStorage.Interfaces
{
    public interface IGameInfoStorage
    {
        void Insert(string name, string heartwood, string barkOre, string bloodSap);
        void Remove(int id);
        void Update(int id, string name, string heartwood, string barkOre, string bloodSap);
    }
}