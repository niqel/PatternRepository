using Microsoft.EntityFrameworkCore;
using PatternRepository.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternRepository
{
    public class LogRepository<TEntity> : PatternRepository<TEntity> where TEntity : EntityLog, new()
    {
        public LogRepository(DbContext dbContext) : base(dbContext)
        {

        }
        public IQueryable<TEntity> FindByIdStatus(int statusId)
        {
            return this.dbSet.Where(x => x.StatusId == statusId);
        }

        public IQueryable<TEntity> FindByForeignId(int foreignId)
        {
            return this.dbSet.Where(x => x.ForeignId == foreignId);
        }
    }
}
