using Microsoft.EntityFrameworkCore;

namespace ER.Application.IRepository
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Table { get; }
    }
}
