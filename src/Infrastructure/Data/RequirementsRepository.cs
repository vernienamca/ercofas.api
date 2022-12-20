using ERCOFAS.ApplicationCore.Entities.Security;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.Infrastructure.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.Api.Infrastructure.Data
{
    public class RequirementsRepository : EFRepository<Requirements, int>, IRequirementsRepository
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RequirementsRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public RequirementsRepository(ERCOFASContext context) : base(context)
        {
        }

        #endregion Constructor

        #region Public

        public IQueryable<Requirements> Get()
        {
            return _context.Requirements;
        }

        public async Task<Requirements> GetById(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<Requirements> Add(Requirements requirement)
        {
            return await AddAsync(requirement);
        }

        public async Task<Requirements> Update(Requirements requirement)
        {
            return await UpdateAsync(requirement);
        }

        public Task Delete(Requirements requirement)
        {
            return DeleteAsync(requirement);
        }

        #endregion Public
    }
}
