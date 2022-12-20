using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.Infrastructure.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.Api.Infrastructure.Data
{
    public class CaseTypeRepository : EFRepository<CaseType, byte>, ICaseTypeRepository
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseTypeRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public CaseTypeRepository(ERCOFASContext context) : base(context)
        {
        }

        #endregion Constructor

        #region Public

        public IQueryable<CaseType> Get()
        {
            return _context.CaseTypes;
        }

        public async Task<CaseType> GetById(byte id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<CaseType> Add(CaseType caseType)
        {
            return await AddAsync(caseType);
        }

        public async Task<CaseType> Update(CaseType caseType)
        {
            return await UpdateAsync(caseType);
        }

        public Task Delete(CaseType caseType)
        {
            return DeleteAsync(caseType);
        }

        #endregion Public
    }
}
