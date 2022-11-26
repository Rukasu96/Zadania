namespace Lekcja15
{
    public interface IDataSource
    {
        Task<Kurs[]> GetData();
    }
}