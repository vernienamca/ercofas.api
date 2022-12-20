using ERCOFAS.ApplicationCore.Entities.Security;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IPageRepository
    {
        /// <summary>
        /// Lists the pages.
        /// </summary>
        /// <returns></returns>
        IQueryable<Page> Get();
        /// <summary>
        /// Gets the page by identifier asynchronous.
        /// </summary>
        /// <param name="id">The page identifier.</param>
        /// <returns></returns>
        Task<Page> GetById(int id);
        /// <summary>
        /// Updates the role asynchronous.
        /// </summary>
        /// <param name="page">The page entity.</param>
        /// <returns></returns>
        Task<Page> Update(Page page);
    }
}
