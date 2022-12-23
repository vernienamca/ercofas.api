using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.ApplicationCore.Services
{
    public class HearingService : IHearingService
    {
        #region Variables

        private readonly IHearingRepository _repository;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HearingService"/> class.
        /// </summary>
        /// <param name="repository">The pre-filing request repository.</param>
        public HearingService(IHearingRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region Methods

        public async Task<Hearing> Add(HearingDTO hearingDTO)
        {
            var request = new Hearing()
            {
                Description = hearingDTO.Description,
                HearingType = hearingDTO.HearingType,
                Schedule = hearingDTO.Schedule,
                MeetingLink = hearingDTO.MeetingLink,    
                CreatedBy = 0,
                DateCreated = DateTime.Now
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

        public Task Delete(HearingDTO hearingDTO)
        {
            var request = _repository.GetById(hearingDTO.Id).Result;
            return _repository.Delete(request);
        }

        public IQueryable<HearingDTO> Get(int? userId = null)
        {
            return _repository.Get(userId);
        }

        public Task<Hearing> GetById(int id)
        {
            return _repository.GetById(Convert.ToByte(id));
        }

        public IQueryable<Hearing> GetHearings()
        {
            return _repository.Get();
        }

        public IQueryable<HearingType> GetHearingTypes()
        {
            throw new NotImplementedException();
        }

        public async Task<Hearing> Update(HearingDTO hearingDTO)
        {
            var request = _repository.GetById(hearingDTO.Id).Result;
            request.Description = hearingDTO.Description;
            request.HearingType = hearingDTO.HearingType;
            request.Schedule = hearingDTO.Schedule;
            request.MeetingLink = hearingDTO.MeetingLink;
            request.DateUpdated = DateTime.Now;

            return await _repository.Update(request);
        }             

        #endregion
    }
}
