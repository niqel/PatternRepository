using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PatternRepository.Interfaces
{
    public interface IDbContext
    {
        public DbSet<TEntity> Set<TEntity>()where TEntity : class;
    }
}
