using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Helpers;
using ERCOFAS.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERCOFAS.Api.Controllers
{
    /// <summary>
    /// The hearing request controller.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class HearingController : ControllerBase
    {
        #region Variables

        private readonly IHearingService _service;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HearingController"/> class.
        /// <param name="roleService">The hearing request service.</param>
        /// </summary>
        public HearingController(IHearingService service)
        {
            _service = service;
        }

        #endregion Constructor

        #region Post

        /// <summary>
        /// Posts the create hearing request.
        /// </summary>
        /// <param name="data">The hearing request data object.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">command</exception>
        [HttpPost]
        public async Task<IActionResult> PostCreateHearingAsync([FromBody] HearingDTO data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            var hearing = await _service.Add(data);

            return Ok(hearing);
        }

        #endregion Post

        #region Put

        /// <summary>
        /// Puts the hearing request.
        /// </summary>
        /// <param name="data">The hearing request data object.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">command</exception>
        [HttpPut]
        public async Task<IActionResult> PutUpdateHearingAsync([FromBody] HearingDTO data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            var preFiling = await _service.Update(data);

            return Ok(preFiling);
        }

        #endregion Put

        #region Get

        /// <summary>
        /// Gets the hearing request by identifier.
        /// </summary>
        /// <param name="id">The hearing request identifier.</param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetHearingById(int id)
        {
            var entity = await _service.GetById(id);

            return Ok(entity);
        }

        #endregion Get

        #region List

        /// <summary>
        /// Gets the list hearing requests.
        /// </summary>
        /// <returns></returns>
        [HttpGet("lists")]
        public async Task<IActionResult> GetListHearingAsync([FromQuery] string searchValue = "", int currentPage = 1, int pageSize = 10, int? userId = null)
        {
            IQueryable<HearingDTO> items = _service.Get(userId);

            if (!string.IsNullOrEmpty(searchValue))
                items = items.Where(x => x.Description.ToLower().Contains(searchValue.ToLower()));

            var paginatedList = await PaginatedList<HearingDTO>.CreateAsync(items.OrderByDescending(x => x.Id), currentPage, pageSize);

            var pagination = new
            {
                totalItems = items.Count(),
                paginatedList.PageCount,
                paginatedList.PageSize
            };

            return Ok(new { items, pagination });
        }

        /// <summary>
        /// Gets the list hearings.
        /// </summary>
        /// <returns></returns>
        [HttpGet("hearing-list")]
        public IActionResult GetListHearings()
        {
            var items = _service.GetHearings();

            return Ok(items);
        }

        #endregion List

        #region Delete        

        /// <summary>
        /// Deletes the hearing request.
        /// </summary>
        /// <param name="id">The hearing request identifier.</param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteHearingRequestAsync(int id)
        {
            var request = await _service.GetById(id);
            
            if (request != null)
            {
                HearingDTO hearingDTO = new HearingDTO()
                {
                    Id = request.Id,
                    Description = request.Description,
                    HearingType = request.HearingType,
                    Schedule = request.Schedule,
                    MeetingLink = request.MeetingLink
                };

                await _service.Delete(hearingDTO);
            }

            return Ok();
        }

        #endregion Delete  
    }
}
