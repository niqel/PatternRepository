using Microsoft.EntityFrameworkCore;
using PatternRepository.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternRepository
{
    public class OperationRepository<TEntity> : PatternUpdateRepository<TEntity> where TEntity : EntityOperation, new()
    {
        public OperationRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public IQueryable<TEntity> FindByIdStatus(int statusId)
        {
            return this.dbSet.Where(x => x.StatusId == statusId);
        }
    }
}
