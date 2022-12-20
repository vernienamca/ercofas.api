using ERCOFAS.ApplicationCore.Entities.Structure;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface ICaseNatureRepository
    {
        /// <summary>
        /// Lists the case natures.
        /// </summary>
        /// <returns></returns>
        IQueryable<CaseNature> Get();
        /// <summary>
        /// Gets the case nature by identifier asynchronous.
        /// </summary>
        /// <param name="id">The case nature identifier.</param>
        /// <returns></returns>
        Task<CaseNature> GetById(byte id);
        /// <summary>
        /// Saves the case nature asynchronous.
        /// </summary>
        /// <param name="caseNature">The case nature entity.</param>
        /// <returns></returns>
        Task<CaseNature> Add(CaseNature caseNature);
        /// <summary>
        /// Updates the case nature asynchronous.
        /// </summary>
        /// <param name="caseNature">The case nature entity.</param>
        /// <returns></returns>
        Task<CaseNature> Update(CaseNature caseNature);
        /// <summary>
        /// Deletes the case nature asynchronous.
        /// </summary>
        /// <param name="caseNature">The case nature entity.</param>
        /// <returns></returns>
        Task Delete(CaseNature caseNature);
    }
}
