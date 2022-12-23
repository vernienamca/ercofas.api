using ERCOFAS.Api.Infrastructure.Data;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERCOFAS.Infrastructure.Data
{
    public class HearingTypeRepository : EFRepository<HearingType, byte>, IHearingTypeRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HearingTypeRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>

        #region Constructor

        public HearingTypeRepository(ERCOFASContext context) : base(context)
        {
        }

        #endregion

        #region Methods

        public async Task<HearingType> Add(HearingType hearingType)
        {
            return await AddAsync(hearingType);
        }

        public Task Delete(HearingType hearingType)
        {
            return DeleteAsync(hearingType);
        }

        public IQueryable<HearingType> Get()
        {
            return _context.HearingTypes;
        }

        public async Task<HearingType> GetById(byte id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<HearingType> Update(HearingType hearingType)
        {
            return await UpdateAsync(hearingType);
        }

        #endregion
    }
}
