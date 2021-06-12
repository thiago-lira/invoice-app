using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class RepositoryBase<T> where T : ModelBase
    {
        protected readonly ApplicationDbContext Context;
        protected readonly DbSet<T> DbSet;

        public RepositoryBase(ApplicationDbContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }
    }
}
