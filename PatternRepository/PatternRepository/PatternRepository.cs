using Microsoft.EntityFrameworkCore;
using PatternRepository.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternRepository
{
    public class PatternRepository<TEntity> : GenericRepository<TEntity> where TEntity : EntityPattern, new()
    {
        public PatternRepository(DbContext dbContext):base(dbContext)
        {

        }

        public IQueryable<TEntity> FindByCreatedBy(int createdBy)
        {
            return this.dbSet.Where(x => x.CreatedBy == createdBy);
        }

        public IQueryable<TEntity> FindByCreatedAt(DateTime createdAt)
        {
            return this.dbSet.Where(x => x.CreatedAt == createdAt);
        }

        public IQueryable<TEntity> FindCreatedAtLessThan(DateTime date)
        {
            return this.dbSet.Where(x => x.CreatedAt < date);
        }

        public IQueryable<TEntity> FindCreatedAtGreaterThan(DateTime date)
        {
            return this.dbSet.Where(x => x.CreatedAt > date);
        }

        public IQueryable<TEntity> FindCreatedAtBetween(DateTime InitialDate, DateTime finalDate)
        {
            return this.dbSet.Where(x => x.CreatedAt >= InitialDate && x.CreatedAt <= finalDate);
        }
    }
}
