using Microsoft.EntityFrameworkCore;
using PatternRepository.AbstractClass;
using PatternRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternRepository
{
    public class CatalogRepository<TEntity> : PatternUpdateRepository<TEntity> where TEntity : EntityCatalog, new()
    {
        public CatalogRepository(DbContext dbContext) : base(dbContext)
        { 
        }

        public IQueryable<TEntity> FindByActive(bool isActive)
        {
            return this.dbSet.Where(x => x.Active == isActive);
        }

        public IQueryable<TEntity> FindByCode(string code)
        {
            return this.dbSet.Where(x => x.Code == code);
        }
    }
}
