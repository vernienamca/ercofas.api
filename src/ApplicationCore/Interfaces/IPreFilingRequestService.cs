using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Security;
using ERCOFAS.ApplicationCore.Entities.Structure;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IPreFilingRequestService
    {
        IQueryable<PreFilingRequestListDTO> Get(long? userId = null);
        Task<PreFilingRequest> GetById(int id);
        IQueryable<CaseType> GetCaseTypes();
        IQueryable<CaseNature> GetCaseNatures(byte caseTypeId);
        Task<PreFilingRequest> Add(PreFilingRequestDTO requestDTO);
        Task<PreFilingRequest> Update(PreFilingRequestDTO requestDTO);
        Task Delete(PreFilingRequest request);
        IQueryable<dynamic> GetDocuments();
    }
}
