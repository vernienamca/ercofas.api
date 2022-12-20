using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.Infrastructure.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.Api.Infrastructure.Data
{
    public class CaseNatureRepository : EFRepository<CaseNature, byte>, ICaseNatureRepository
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseNatureRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public CaseNatureRepository(ERCOFASContext context) : base(context)
        {
        }

        #endregion Constructor

        #region Public

        public IQueryable<CaseNature> Get()
        {
            return _context.CaseNatures;
        }

        public async Task<CaseNature> GetById(byte id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<CaseNature> Add(CaseNature caseNature)
        {
            return await AddAsync(caseNature);
        }

        public async Task<CaseNature> Update(CaseNature caseNature)
        {
            return await UpdateAsync(caseNature);
        }

        public Task Delete(CaseNature caseNature)
        {
            return DeleteAsync(caseNature);
        }

        #endregion Public
    }
}
