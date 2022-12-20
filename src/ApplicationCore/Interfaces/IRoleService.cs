using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Security;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IRoleService
    {
        IQueryable<Role> Get();
        Task<Role> GetById(int id);
        Task<Role> Add(RoleDTO roleDTO);
        Task<Role> Update(RoleDTO roleDTO);
        Task Delete(Role role);
    }
}
