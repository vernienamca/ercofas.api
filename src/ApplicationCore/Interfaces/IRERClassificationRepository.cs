using ERCOFAS.ApplicationCore.Entities.Structure;
using System.Linq;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IRERClassificationRepository
    {
        /// <summary>
        /// Lists the RER classifications by user type.
        /// </summary>
        /// <param name="userTypeId">The user type identifier.</param>
        /// <returns></returns>
        IQueryable<RERClassification> GetRERClassifications(byte? userTypeId);
    }
}
