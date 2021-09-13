using Microsoft.EntityFrameworkCore;
using PatternRepository.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternRepository
{
    public class RelationRepository<TEntity> : PatternRepository<TEntity> where TEntity : EntityRelation, new()
    {
        public RelationRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public IQueryable<TEntity> FindByActive(bool isActive)
        {
            return this.dbSet.Where(x => x.Active == isActive);
        }
    }
}
