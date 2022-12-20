using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Security;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IManageRoleService
    {
        IQueryable<PageAccess> List();
        List<ManageRoleDTO> Get(int pageId);
        Task<PageAccess> GetById(int id, int pageId, int roleId);
        Task<PageAccess> Add(ManageRoleDTO manageRoleDTO);
        Task<PageAccess> Update(ManageRoleDTO manageRoleDTO, PageAccess manageRole);
        Task Delete(PageAccess manageRole);
        Task DeleteRange(int pageId, int[] manageRoleIds);
    }
}
