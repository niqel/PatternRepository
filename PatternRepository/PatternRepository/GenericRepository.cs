using PatternRepository.Interfaces;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatternRepository
{
    public class GenericRepository<TEntity>
     where TEntity : class
    {

        //private readonly IDbContext dbContext;
        private readonly DbContext dbContext;
        private readonly DbSet<TEntity> dbSet;

        public GenericRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();
        }

        //Crea una entidad
        public void Create(TEntity entity)
        {
            dbSet.Add(entity);
        }

        //Crea un rango de entidades
        public void CreateRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                Create(entity);
            }
        }

        //Buscar por id metodo asincrono
        public async Task<TEntity> FindAsync(object id)
        {
            return await this.FindAsync(id); 
        }

        public TEntity Find(object id)
        {
            return dbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }


        public void Update(object id, TEntity entity)
        {
            TEntity returnedEntity = this.Find(id);
            returnedEntity = entity;
            if (returnedEntity != null)
            {
                dbSet.Attach(entity);
                dbContext.Entry(entity).State = EntityState.Modified;
                dbContext.Update(returnedEntity);
            }
        }
        public void Delete(TEntity entity)
        {
            if (dbContext.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        public void Delete(int id)
        {
            TEntity entity = this.Find(id);
            this.Delete(entity);
        }
        public async Task Delete(object id)
        {
            TEntity entity = await this.FindAsync(id);
            if (entity != null)
            {
                this.Delete(entity);
            }
        }
        public IQueryable<TEntity> Queryable()
        {
            return dbSet;
        }
    }
}
