using ERCOFAS.ApplicationCore.Entities.Structure;
using System.Linq;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IRERClassificationService
    {
        IQueryable<RERClassification> GetRERClassifications(byte? userTypeId);
    }
}
