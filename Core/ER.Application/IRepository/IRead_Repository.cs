using System.Linq.Expressions;

namespace ER.Application.IRepository
{
    public interface IRead_Repository<T> : IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetWhere_singleAsync(Expression<Func<T, bool>> method);
       
    }
}
