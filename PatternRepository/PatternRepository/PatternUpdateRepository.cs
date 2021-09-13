using Microsoft.EntityFrameworkCore;
using PatternRepository.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternRepository
{
    public class PatternUpdateRepository<TEntity> : PatternRepository<TEntity> where TEntity : EntityPatternUpdate, new()
    {
        public PatternUpdateRepository(DbContext dbContext) : base(dbContext)
        {

        }
        public IQueryable<TEntity> FindByUpdatedBy(int updatedBy)
        {
            return this.dbSet.Where(x => x.UpdatedBy == updatedBy);
        }

        public IQueryable<TEntity> FindByUpdatedAt(DateTime updatedAt)
        {
            return this.dbSet.Where(x => x.UpdatedAt == updatedAt);
        }

        public IQueryable<TEntity> FindUpdatedAtLessThan(DateTime date)
        {
            return this.dbSet.Where(x => x.CreatedAt < date);
        }

        public IQueryable<TEntity> FindUpdatedAtGreaterThan(DateTime date)
        {
            return this.dbSet.Where(x => x.UpdatedAt > date);
        }

        public IQueryable<TEntity> FindUpdatedAtBetween(DateTime InitialDate, DateTime finalDate)
        {
            return this.dbSet.Where(x => x.UpdatedAt >= InitialDate && x.UpdatedAt <= finalDate);
        }
    }
}
