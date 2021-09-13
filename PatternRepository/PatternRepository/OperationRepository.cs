using Microsoft.EntityFrameworkCore;
using PatternRepository.AbstractClass;
using PatternRepository.Interfaces;
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

        public IQueryable<TEntity> FindByIdStatus(int idStatus)
        {
            return this.dbSet.Where(x => x.IdStatus == idStatus);
        }
    }
}
