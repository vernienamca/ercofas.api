using System.Linq;

namespace ERCOFAS.ApplicationCore.Interfaces
{
    public interface IDocumentsNeededService
    {
        IQueryable<dynamic> Get(string purpose);
    }
}
