using ERCOFAS.ApplicationCore.Entities.Structure;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IRequirementsRepository
    {
        /// <summary>
        /// Lists the requirements.
        /// </summary>
        /// <returns></returns>
        IQueryable<Requirements> Get();
        /// <summary>
        /// Gets the requirement by identifier asynchronous.
        /// </summary>
        /// <param name="id">The requirement identifier.</param>
        /// <returns></returns>
        Task<Requirements> GetById(int id);
        /// <summary>
        /// Saves the requirement asynchronous.
        /// </summary>
        /// <param name="requirement">The requirement entity.</param>
        /// <returns></returns>
        Task<Requirements> Add(Requirements requirement);
        /// <summary>
        /// Updates the requirement asynchronous.
        /// </summary>
        /// <param name="requirement">The requirement entity.</param>
        /// <returns></returns>
        Task<Requirements> Update(Requirements requirement);
        /// <summary>
        /// Deletes the requirement asynchronous.
        /// </summary>
        /// <param name="requirement">The requirement entity.</param>
        /// <returns></returns>
        Task Delete(Requirements requirement);
    }
}
