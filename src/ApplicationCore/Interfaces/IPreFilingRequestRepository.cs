using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Structure;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IPreFilingRequestRepository
    {
        /// <summary>
        /// Lists the pre-filing request by user id.
        /// </summary>
        /// <param name="id">The user id identifier.</param>
        /// <returns></returns>
        IQueryable<PreFilingRequestListDTO> Get(long? userId = null);
        /// <summary>
        /// Gets the pre-filing request by identifier asynchronous.
        /// </summary>
        /// <param name="id">The pre-filing request identifier.</param>
        /// <returns></returns>
        Task<PreFilingRequest> GetById(long id);
        /// <summary>
        /// Lists the case types.
        /// </summary>
        /// <returns></returns>
        IQueryable<CaseType> GetCaseTypes();
        /// <summary>
        /// Lists the case natures by case type.
        /// </summary>
        /// <param name="caseTypeId">The case type identifier.</param>
        /// <returns></returns>
        IQueryable<CaseNature> GetCaseNatures(byte caseTypeId);
        /// <summary>
        /// Saves the pre-filing request asynchronous.
        /// </summary>
        /// <param name="request">The pre-filing request entity.</param>
        /// <returns></returns>
        Task<PreFilingRequest> Add(PreFilingRequest request);
        /// <summary>
        /// Updates the pre-filing request asynchronous.
        /// </summary>
        /// <param name="request">The pre-filing request entity.</param>
        /// <returns></returns>
        Task<PreFilingRequest> Update(PreFilingRequest request);
        /// <summary>
        /// Deletes the pre-filing request asynchronous.
        /// </summary>
        /// <param name="request">The re-filing request entity.</param>
        /// <returns></returns>
        Task Delete(PreFilingRequest request);
        /// <summary>
        /// Lists the pre-filing documents.
        /// </summary>
        /// <returns></returns>
        IQueryable<dynamic> GetDocuments();
    }
}
