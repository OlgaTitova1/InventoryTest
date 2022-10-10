using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Interfaces
{
    public interface IRepository<T>
    {
        /// <summary>
        /// Returns the T by its given id.
        /// </summary>
        /// <returns>The Entity T.</returns>
        Task<T> GetByIdAsync(long id);
        /// <summary>
        /// Returns the T by its given id.
        /// </summary>
        /// <returns>The Entity T.</returns>
        Task<T> GetByIdAsync(int id);

        /// <summary>
        /// Returns the T by its given id.
        /// </summary>
        /// <returns>The Entity T.</returns>
        Task<T> GetByIdAsync(byte id);

        /// Returns the T by its given id.
        /// </summary>
        /// <returns>The Entity T.</returns>
        Task<T> GetByIdAsync(string id);

        /// Returns the T by its given id.
        /// </summary>
        /// <returns>The Entity T.</returns>
        Task<T> GetByIdAsync(short id);

        /// <summary>
        /// Returns a single T by the given criteria.
        /// </summary>
        /// <param name="criteria">The expression.</param>
        /// <returns>A single T matching the criteria.</returns>
        Task<T> GetSingleOrDefaultAsync(Expression<Func<T, bool>> criteria);

        /// <summary>
        /// Returns is any by the given criteria.
        /// </summary>
        /// <param name="criteria">The expression.</param>
        /// <returns>bool</returns>
        Task<bool> AnyAsync(Expression<Func<T, bool>> criteria);

        /// <summary>
        /// Returns All the records of T.
        /// </summary>
        /// <param name="take">Optional parameter. How many records to take from resulting collection.</param>
        /// <returns>IQueryable of T.</returns>
        IQueryable<T> GetAll(int? take = null);

        /// <summary>
        /// Returns the list of T where it matches the criteria.
        /// </summary>
        /// <param name="criteria">The expression.</param>
        /// <param name="take">Optional parameter. How many records to take from resulting collection.</param>
        /// <returns>IQueryable of T.</returns>
        IQueryable<T> GetAll(Expression<Func<T, bool>> criteria, int? take = null);

        /// <summary>
        /// Adds the new entity in the repository.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        /// <returns>The added entity including its new Id.</returns>
        void Add(T entity);

        /// <summary>
        /// Adds the new entities in the repository.
        /// </summary>
        /// <param name="entities">The entities of type T.</param>
        /// <returns>The added entities including its new Id.</returns>
        void Add(IEnumerable<T> entities);

        /// <summary>
        /// Deletes an entity from the repository by its id.
        /// </summary>
        /// <param name="id">The id of the entity.</param>
        Task DeleteAsync(int id);

        /// <summary>
        /// Deletes the given entity.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        void Delete(T entity);

        /// <summary>
        /// Counts the total entities in the repository.
        /// </summary>
        /// <returns>Count of entities in the repository.</returns>
        Task<int> CountAsync();

        /// <summary>
        /// Counts the total entities in the repository.
        /// </summary>
        /// <returns>Count of entities in the repository.</returns>
        Task<int> CountAsync(Expression<Func<T, bool>> criteria);

        /// <summary>
        /// Saves all changes made in this context to the underlying database.
        /// </summary>
        Task SaveChangesAsync();
    }
}
