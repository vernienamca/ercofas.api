using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Services
{
    public class PreFilingRequestService : IPreFilingRequestService
    {
        #region Variables

        private readonly IPreFilingRequestRepository _repository;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PreFilingRequestService"/> class.
        /// </summary>
        /// <param name="repository">The pre-filing request repository.</param>
        public PreFilingRequestService(IPreFilingRequestRepository repository)
        {
            _repository = repository;
        }

        #endregion Constructor

        #region Public

        public IQueryable<PreFilingRequestListDTO> Get(long? userId = null)
        {
            return _repository.Get(userId);
        }

        public async Task<PreFilingRequest> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public IQueryable<CaseType> GetCaseTypes()
        {
            return _repository.GetCaseTypes();
        }

        public IQueryable<CaseNature> GetCaseNatures(byte caseTypeId)
        {
            return _repository.GetCaseNatures(caseTypeId);
        }

        public async Task<PreFilingRequest> Add(PreFilingRequestDTO requestDTO)
        {
            var request = new PreFilingRequest()
            {
                RequestSubject = requestDTO.RequestSubject,
                UserId = requestDTO.UserId,
                CaseTypeId = requestDTO.CaseTypeId,
                CaseNatureId = requestDTO.CaseNatureId,
                PreFilingStatusId = 3,
                Remarks = requestDTO.Remarks,
                DateFiled = DateTime.Now
            };

            try
            {
                return await _repository.Add(request);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<PreFilingRequest> Update(PreFilingRequestDTO requestDTO)
        {
            var request = _repository.GetById(requestDTO.Id).Result;
            request.RequestSubject = requestDTO.RequestSubject;
            request.CaseTypeId = requestDTO.CaseTypeId;
            request.CaseNatureId = requestDTO.CaseNatureId;
            request.Remarks = requestDTO.Remarks;
            request.DateUpdated = DateTime.Now;

            return await _repository.Update(request);
        }

        public async Task Delete(PreFilingRequest request)
        {
            await _repository.Delete(request);
        }

        public IQueryable<dynamic> GetDocuments()
        {
            return _repository.GetDocuments();
        }

        #endregion Public
    }
}
