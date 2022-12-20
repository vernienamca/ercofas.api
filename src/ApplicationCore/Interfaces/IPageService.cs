using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Security;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IPageService
    {
        IQueryable<Page> Get();
        Task<Page> GetById(int id);
        Task<Page> Update(PageDTO pageDTO);
    }
}
