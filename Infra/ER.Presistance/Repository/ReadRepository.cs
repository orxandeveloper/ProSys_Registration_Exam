using ER.Application.IRepository;
using ER.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ER.Presistance.Repository
{
    public class ReadRepository<T> : IRead_Repository<T> where T : class
    {
        readonly ProSysExamContext context;

        public ReadRepository(ProSysExamContext context)
        {
            this.context = context;
        }

        public DbSet<T> Table => context.Set<T>();

        public async Task<List<T>> GetAllAsync()
        {
            return await Table.ToListAsync();
        }

        public Task<T> GetWhere_singleAsync(Expression<Func<T, bool>> method) => Table.Where(method).SingleOrDefaultAsync();

         
    }
}
