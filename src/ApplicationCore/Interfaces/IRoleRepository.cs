using ERCOFAS.ApplicationCore.Entities.Security;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IRoleRepository
    {
        /// <summary>
        /// Lists the roles.
        /// </summary>
        /// <returns></returns>
        IQueryable<Role> Get();
        /// <summary>
        /// Gets the role by identifier asynchronous.
        /// </summary>
        /// <param name="id">The role identifier.</param>
        /// <returns></returns>
        Task<Role> GetById(int id);
        /// <summary>
        /// Saves the role asynchronous.
        /// </summary>
        /// <param name="role">The role entity.</param>
        /// <returns></returns>
        Task<Role> Add(Role role);
        /// <summary>
        /// Updates the role asynchronous.
        /// </summary>
        /// <param name="role">The role entity.</param>
        /// <returns></returns>
        Task<Role> Update(Role role);
        /// <summary>
        /// Deletes the role asynchronous.
        /// </summary>
        /// <param name="role">The role entity.</param>
        /// <returns></returns>
        Task Delete(Role role);
    }
}
