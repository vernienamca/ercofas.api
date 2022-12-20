using ERCOFAS.ApplicationCore.Entities.Security;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.Infrastructure.Data;
using System.Linq;

namespace ERCOFAS.Api.Infrastructure.Data
{
    public class RERClassificationRepository : EFRepository<RERClassification, byte>, IRERClassificationRepository
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RERClassificationRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public RERClassificationRepository(ERCOFASContext context) : base(context)
        {
        }

        #endregion Constructor

        #region Public

        public IQueryable<RERClassification> GetRERClassifications(byte? userTypeId)
        {
            IQueryable<RERClassification> rERClassifications = _context.RERClassifications;

            if (userTypeId.HasValue)
                rERClassifications = rERClassifications.Where(x => x.UserTypeId == userTypeId);

            return rERClassifications;
        }

        #endregion Public
    }
}
