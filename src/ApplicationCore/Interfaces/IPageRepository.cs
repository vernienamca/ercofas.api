using ERCOFAS.ApplicationCore.Entities.Structure;
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
        /// Saves the page asynchronous.
        /// </summary>
        /// <param name="page">The page entity.</param>
        /// <returns></returns>
        Task<Page> Add(Page page);
        /// <summary>
        /// Updates the page asynchronous.
        /// </summary>
        /// <param name="page">The page entity.</param>
        /// <returns></returns>
        Task<Page> Update(Page page);
    }
}
