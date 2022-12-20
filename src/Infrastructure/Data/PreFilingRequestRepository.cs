using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Security;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using ERCOFAS.Infrastructure.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.Api.Infrastructure.Data
{
    public class PreFilingRequestRepository : EFRepository<PreFilingRequest, long>, IPreFilingRequestRepository
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PreFilingRequestRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public PreFilingRequestRepository(ERCOFASContext context) : base(context)
        {
        }

        #endregion Constructor

        #region Public

        public IQueryable<PreFilingRequestListDTO> Get(long? userId = null)
        {
            var data = (from pfr in _context.PreFilingRequests
                        join cnt in _context.CaseNatures on pfr.CaseNatureId equals cnt.Id
                        join ctp in _context.CaseTypes on pfr.CaseTypeId equals ctp.Id
                        join pfs in _context.PreFilingStatus on pfr.PreFilingStatusId equals pfs.Id
                        join usr in _context.Users on pfr.UserId equals usr.Id
                        select new PreFilingRequestListDTO()
                        {
                            Id = pfr.Id,
                            RequestSubject = pfr.RequestSubject,
                            UserId = pfr.UserId,
                            FullName = usr.FirstName + " " + usr.LastName,
                            CaseType = ctp.Description,
                            CaseNature = cnt.Description,
                            PreFilingStatus = pfs.Description,
                            DateFiled = pfr.DateFiled
                        }).OrderByDescending(x => x.Id);

            if (userId.HasValue)
                data = data.Where(x => x.UserId == userId).OrderByDescending(x => x.Id);

            return data;
        }

        public async Task<PreFilingRequest> GetById(long id)
        {
            return await GetByIdAsync(id);
        }

        public IQueryable<CaseType> GetCaseTypes()
        {
            return _context.CaseTypes;
        }

        public IQueryable<CaseNature> GetCaseNatures(byte caseTypeId)
        {
            return _context.CaseNatures.Where(x => x.CaseTypeId == caseTypeId);
        }

        public async Task<PreFilingRequest> Add(PreFilingRequest request)
        {
            return await AddAsync(request);
        }

        public async Task<PreFilingRequest> Update(PreFilingRequest request)
        {
            return await UpdateAsync(request);
        }

        public Task Delete(PreFilingRequest request)
        {
            return DeleteAsync(request);
        }

        public IQueryable<dynamic> GetDocuments()
        {
            var data = (from doc in _context.DocumentsNeeded
                        join req in _context.Requirements on doc.RequirementsId equals req.Id
                        where doc.Purpose == "Pre-Filing Request"
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
