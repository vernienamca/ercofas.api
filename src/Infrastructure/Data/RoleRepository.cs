using ERCOFAS.ApplicationCore.Entities.Security;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.Infrastructure.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.Api.Infrastructure.Data
{
    public class RoleRepository : EFRepository<Role, int>, IRoleRepository
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public RoleRepository(ERCOFASContext context) : base(context)
        {
        }

        #endregion Constructor

        #region Public

        public IQueryable<Role> Get()
        {
            return _context.Roles;
        }

        public async Task<Role> GetById(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<Role> Add(Role role)
        {
            return await AddAsync(role);
        }

        public async Task<Role> Update(Role role)
        {
            return await UpdateAsync(role);
        }

        public Task Delete(Role role)
        {
            return DeleteAsync(role);
        }

        #endregion Public
    }
}
