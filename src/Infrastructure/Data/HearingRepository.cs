using ERCOFAS.Api.Infrastructure.Data;
using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.Infrastructure.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.Infrastructure.Data
{
    public class HearingRepository : EFRepository<Hearing, int>, IHearingRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HearingRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>

        #region Constructor

        public HearingRepository(ERCOFASContext context) : base(context)
        {
        }

        #endregion

        #region Methods

        public async Task<Hearing> Add(Hearing hearing)
        {
            return await AddAsync(hearing);
        }

        public Task Delete(Hearing hearing)
        {
            return DeleteAsync(hearing);
        }

        public IQueryable<Hearing> Get()
        {
            return _context.Hearings;
        }

        public IQueryable<HearingDTO> Get(int? userId = null)
        {
            var data = (from hear in _context.Hearings                        
                        select new HearingDTO()
                        {
                            Id = hear.Id,
                            Description = hear.Description,
                            HearingType = hear.HearingType,
                            Schedule = hear.Schedule,
                            MeetingLink = hear.MeetingLink,
                            DateFiled = hear.DateCreated
                        }).OrderByDescending(x => x.Id);

            if (userId.HasValue)
                data = data.Where(x => x.Id == userId).OrderByDescending(x => x.Id);

            return data;
        }

        public async Task<Hearing> GetById(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<Hearing> Update(Hearing hearing)
        {
            return await UpdateAsync(hearing);
        }

        #endregion
    }
}
