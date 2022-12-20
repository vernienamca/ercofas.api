using ERCOFAS.ApplicationCore.Entities.Security;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IDocumentsNeededRepository
    {
        /// <summary>
        /// Lists the documents needed by purpose.
        /// </summary>
        /// <returns></returns>
        IQueryable<dynamic> Get(string purpose);
    }
}
