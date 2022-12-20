using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ERCOFAS.Api.Infrastructure.Data;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.ApplicationCore;

namespace ERCOFAS.Infrastructure.Data
{
    /// <summary>
    /// Repository to handle entity framework common operation.
    /// </summary>
    public class EFRepository<EntityType, IdType> : IAsyncRepository<EntityType, IdType> where EntityType : BaseEntity<IdType>
    {
        #region Variables

        protected readonly ERCOFASContext _context;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="EFRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public EFRepository(ERCOFASContext context)
        {
            _context = context;
        }

        #endregion Constructor

        #region Public

        /// <summary>
        /// Creates a List<T> from an IQueryable. Async version
        /// </summary>
        /// <returns></returns>
        public async Task<List<EntityType>> ListAllAsync()
        {
            return await _context.Set<EntityType>().ToListAsync();
        }

        /// <summary>
        ///  Find an entity with given primary key values. Async version
        /// </summary>
        /// <param name="entity">The entity type.</param>
        /// <returns></returns>
        public async Task<EntityType> GetByIdAsync(IdType id)
        {
            return await _context.Set<EntityType>().FindAsync(id);
        }

        /// <summary>
        /// Saves the changes made in this context. Async version
        /// </summary>
        /// <param name="entity">The entity type.</param>
        /// <returns></returns>

        public async Task<EntityType> AddAsync(EntityType entity)
        {
            _context.Set<EntityType>().Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        /// <summary>
        /// Updates the changes made in this context. Async version
        /// </summary>
        /// <param name="entity">The entity type.</param>
        /// <returns></returns>
        public async Task<EntityType> UpdateAsync(EntityType entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return entity;
        }

        /// <summary>
        /// Deletes record from a database obtained by the context. Async version
        /// </summary>
        /// <param name="entity">The entity type.</param>
        /// <returns></returns>
        public async Task DeleteAsync(EntityType entity)
        {
            _context.Set<EntityType>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes multiple records from a database obtained by the context. Async version
        /// </summary>
        /// <param name="entity">The entity type.</param>
        /// <returns></returns>
        public async Task DeleteRangeAsync(List<EntityType> entity)
        {
            _context.Set<EntityType>().RemoveRange(entity);
            await _context.SaveChangesAsync();
        }

        #endregion Public
    }
}