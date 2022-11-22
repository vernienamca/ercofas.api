using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.Infrastructure.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.Api.Infrastructure.Data
{
    public class SettingsRepository : EFRepository<Settings, int>, ISettingsRepository
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public SettingsRepository(ERCOFASContext context) : base(context)
        {
        }

        #endregion Constructor

        #region Public

        public IQueryable<Settings> Get()
        {
            return _context.Settings;
        }

        public async Task<Settings> GetById(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<Settings> Add(Settings settings)
        {
            return await AddAsync(settings);
        }

        public async Task<Settings> Update(Settings settings)
        {
            return await UpdateAsync(settings);
        }

        #endregion Public
    }
}
