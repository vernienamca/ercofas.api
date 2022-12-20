using ERCOFAS.ApplicationCore.Entities.Security;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.Infrastructure.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.Api.Infrastructure.Data
{
    public class DocumentsNeededRepository : EFRepository<DocumentsNeeded, long>, IDocumentsNeededRepository
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsNeededRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public DocumentsNeededRepository(ERCOFASContext context) : base(context)
        {
        }

        #endregion Constructor

        #region Public

        public IQueryable<dynamic> Get(string purpose)
        {
            var data = (from doc in _context.DocumentsNeeded
                        join req in _context.Requirements on doc.RequirementsId equals req.Id
                        where doc.Purpose == purpose
                        select new
                        {
                            doc.Id,
                            req.Name,
                            doc.IsRequired
                        });

            return data;
        }

        #endregion Public
    }
}
