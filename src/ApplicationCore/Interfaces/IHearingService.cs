using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Structure;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IHearingService
    {
        IQueryable<HearingDTO> Get(int? userId = null);
        Task<Hearing> GetById(int id);
        IQueryable<Hearing> GetHearings();
        IQueryable<HearingType> GetHearingTypes();
        Task<Hearing> Add(HearingDTO hearingDTO);
        Task<Hearing> Update(HearingDTO hearingDTO);
        Task Delete(HearingDTO hearingDTO);
    }
}
