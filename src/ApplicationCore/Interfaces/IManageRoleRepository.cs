using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Security;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IManageRoleRepository
    {
        /// <summary>
        /// Lists the manage roles.
        /// </summary>
        /// <returns></returns>
        IQueryable<PageAccess> List();
        /// <summary>
        /// Gets the manage roles.
        /// </summary>
        /// <param name="pageId">The page identifier.</param>
        /// <returns></returns>
        List<ManageRoleDTO> Get(int pageId);
        /// <summary>
        /// Gets the manage role by identifier asynchronous.
        /// </summary>
        /// <param name="id">The manage role identifier.</param>
        /// <param name="pageId">The page identifier.</param>
        /// <param name="roleId">The role identifier.</param>
        /// <returns></returns>
        Task<PageAccess> GetById(int id, int pageId, int roleId);
        /// <summary>
        /// Saves the manage roles asynchronous.
        /// </summary>
        /// <param name="manageRole">The manage roles entity.</param>
        /// <returns></returns>
        Task<PageAccess> Add(PageAccess manageRole);
        /// <summary>
        /// Updates the manage roles asynchronous.
        /// </summary>
        /// <param name="manageRole">The manage roles entity.</param>
        /// <returns></returns>
        Task<PageAccess> Update(PageAccess manageRole);
        /// <summary>
        /// Deletes the roles asynchronous.
        /// </summary>
        /// <param name="manageRoles">The manage roles entity.</param>
        /// <returns></returns>
        Task Delete(PageAccess manageRole);
        /// <summary>
        /// Deletes the ranges of manage roles asynchronous.
        /// </summary>
        /// <param name="pageId">The page identifier.</param>
        /// <param name="manageRolesDTO">The list of manage roles data object.</param>
        /// <returns></returns>
        Task DeleteRange(int pageId, int[] manageRoleIds);
    }
}
