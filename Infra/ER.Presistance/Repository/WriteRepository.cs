using ER.Application.IRepository;
using ER.Domain;
using Microsoft.EntityFrameworkCore;

namespace ER.Presistance.Repository
{
    public class WriteRepository<T> : IWrite_Repository<T> where T : class
    {
        readonly ProSysExamContext context;

        public WriteRepository(ProSysExamContext context)
        {
            this.context = context;
        }

        public DbSet<T> Table => context.Set<T>();

        public Task<int> SaveDataAsync(T entity)
        {
           context.Attach(entity);
            return context.SaveChangesAsync();
        }
    }
}
