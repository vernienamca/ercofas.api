using ERCOFAS.ApplicationCore.Entities.Security;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.Infrastructure.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.Api.Infrastructure.Data
{
    public class PageRepository : EFRepository<Page, int>, IPageRepository
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PageRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public PageRepository(ERCOFASContext context) : base(context)
        {
        }

        #endregion Constructor

        #region Public

        public IQueryable<Page> Get()
        {
            return _context.Pages;
        }

        public async Task<Page> GetById(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<Page> Update(Page page)
        {
            return await UpdateAsync(page);
        }

        public Task Delete(Page manageRole)
        {
            return DeleteAsync(manageRole);
        }

        #endregion Public
    }
}
