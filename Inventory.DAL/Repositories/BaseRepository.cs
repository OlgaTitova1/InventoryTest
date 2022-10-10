using Inventory.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public class BaseRepository<T> : IRepository<T>, IDisposable
       where T : class
    {
        protected readonly DbContext dbContext;

        protected DbSet<T> DbSet { get; set; }

        public BaseRepository()
        {
        }

        public BaseRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.DbSet = dbContext.Set<T>();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await this.DbSet.FindAsync(id);
        }

        public async Task<T> GetByIdAsync(long id)
        {
            return await this.DbSet.FindAsync(id);
        }

        public async Task<T> GetByIdAsync(byte id)
        {
            return await this.DbSet.FindAsync(id);
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await this.DbSet.FindAsync(id);
        }

        public async Task<T> GetByIdAsync(short id)
        {
            return await this.DbSet.FindAsync(id);
        }

        public virtual async Task<T> GetSingleOrDefaultAsync(Expression<Func<T, bool>> criteria)
        {
            return await this.DbSet.SingleOrDefaultAsync(criteria);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> criteria)
        {
            return await this.DbSet.AnyAsync(criteria);
        }

        public virtual IQueryable<T> GetAll(int? take = null)
        {
            if (take.HasValue)
            {
                return this.DbSet.Take(take.Value);
            }

            return this.DbSet.AsQueryable();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> criteria, int? take = null)
        {
            if (take.HasValue)
            {
                return this.DbSet.Where(criteria).Take(take.Value);
            }

            return this.DbSet.Where(criteria);
        }

        public virtual void Add(T entity)
        {
            this.DbSet.Add(entity);
        }

        public virtual void Add(IEnumerable<T> entities)
        {
            this.DbSet.AddRange(entities);
        }

        public async Task<int> CountAsync()
        {
            return await this.DbSet.CountAsync();
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> criteria)
        {
            return await this.DbSet.CountAsync(criteria);
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await this.GetByIdAsync(id);

            if (entity != null)
            {
                this.Delete(entity);
            }
        }

        public virtual void Delete(T entity)
        {
            this.DbSet.Remove(entity);
        }

        public virtual async Task SaveChangesAsync()
        {
            await this.dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.dbContext.Dispose();
        }
    }
}
