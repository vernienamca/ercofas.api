using ERCOFAS.ApplicationCore.Entities.Structure;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface ICaseTypeRepository
    {
        /// <summary>
        /// Lists the case types.
        /// </summary>
        /// <returns></returns>
        IQueryable<CaseType> Get();
        /// <summary>
        /// Gets the case type by identifier asynchronous.
        /// </summary>
        /// <param name="id">The case type identifier.</param>
        /// <returns></returns>
        Task<CaseType> GetById(byte id);
        /// <summary>
        /// Saves the case type asynchronous.
        /// </summary>
        /// <param name="caseType">The case type entity.</param>
        /// <returns></returns>
        Task<CaseType> Add(CaseType caseType);
        /// <summary>
        /// Updates the case type asynchronous.
        /// </summary>
        /// <param name="caseType">The case type entity.</param>
        /// <returns></returns>
        Task<CaseType> Update(CaseType caseType);
        /// <summary>
        /// Deletes the case type asynchronous.
        /// </summary>
        /// <param name="caseType">The case type entity.</param>
        /// <returns></returns>
        Task Delete(CaseType caseType);
    }
}
