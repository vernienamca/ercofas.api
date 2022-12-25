using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Security;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface ISealingAndAcceptanceTestingService
    {
        IQueryable<SealingAndAcceptanceTesting> Get();
        Task<SealingAndAcceptanceTesting> GetById(int id);
        Task<SealingAndAcceptanceTesting> Add(SealingAndAcceptanceTestingDto sealingAndAcceptanceTestingDTO);
        Task<SealingAndAcceptanceTesting> Update(SealingAndAcceptanceTestingDto sealingAndAcceptanceTestingDTO);
        Task Delete(SealingAndAcceptanceTesting sealingAndAcceptanceTesting);
    }
}
