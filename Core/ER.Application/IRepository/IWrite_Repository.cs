namespace ER.Application.IRepository
{
    public interface IWrite_Repository<T>: IRepository<T> where T : class
    {
        Task<int> SaveDataAsync(T entity);
    }
}
