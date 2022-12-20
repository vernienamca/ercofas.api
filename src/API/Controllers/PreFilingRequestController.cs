using ERCOFAS.Api.Models;
using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Security;
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
    /// The pre-filing request controller.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class PreFilingRequestController : ControllerBase
    {
        #region Variables

        private readonly IPreFilingRequestService _service;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PreFilingRequestController"/> class.
        /// <param name="roleService">The pre-filing request service.</param>
        /// </summary>
        public PreFilingRequestController(IPreFilingRequestService service)
        {
            _service = service;
        }

        #endregion Constructor

        #region Post

        /// <summary>
        /// Posts the create pre-filing request.
        /// </summary>
        /// <param name="data">The pre-filing request data object.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">command</exception>
        [HttpPost]
        public async Task<IActionResult> PostCreatePreFilingRequestAsync([FromBody] PreFilingRequestDTO data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            var preFiling = await _service.Add(data);

            return Ok(preFiling);
        }

        #endregion Post

        #region Put

        /// <summary>
        /// Puts the pre-filing request.
        /// </summary>
        /// <param name="data">The pre-filing request data object.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">command</exception>
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutUpdatePreFilingRequestAsync([FromBody] PreFilingRequestDTO data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            var preFiling = await _service.Update(data);

            return Ok(preFiling);
        }

        #endregion Put

        #region Get

        /// <summary>
        /// Gets the pre-filing request by identifier.
        /// </summary>
        /// <param name="id">The pre-filing request identifier.</param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPreFilingRequestById(int id)
        {
            var entity = await _service.GetById(id);

            return Ok(entity);
        }

        #endregion Get

        #region List

        /// <summary>
        /// Gets the list pre-filing requests.
        /// </summary>
        /// <returns></returns>
        [HttpGet("lists")]
        public async Task<IActionResult> GetListPreFilingRequestsAsync([FromQuery] string searchValue = "", int currentPage = 1, int pageSize = 10, long? userId = null)
        {
            IQueryable<PreFilingRequestListDTO> items = _service.Get(userId);

            if (!string.IsNullOrEmpty(searchValue))
                items = items.Where(x => x.RequestSubject.ToLower().Contains(searchValue.ToLower()));

            var paginatedList = await PaginatedList<PreFilingRequestListDTO>.CreateAsync(items.OrderByDescending(x => x.Id), currentPage, pageSize);

            var pagination = new
            {
                totalItems = items.Count(),
                paginatedList.PageCount,
                paginatedList.PageSize
            };

            return Ok(new { items, pagination });
        }

        /// <summary>
        /// Gets the list case types.
        /// </summary>
        /// <returns></returns>
        [HttpGet("case-types")]
        public IActionResult GetListCaseTypes()
        {
            var items = _service.GetCaseTypes();

            return Ok(items);
        }

        /// <summary>
        /// Gets the list case natures.
        /// </summary>
        /// <returns></returns>
        [HttpGet("case-natures")]
        public IActionResult GetListCaseNatures(byte caseTypeId)
        {
            var items = _service.GetCaseNatures(caseTypeId);

            return Ok(items);
        }

        /// <summary>
        /// Gets the list documents.
        /// </summary>
        /// <returns></returns>
        [HttpGet("documents")]
        public IActionResult GetListDocuments()
        {
            var items = _service.GetDocuments();

            return Ok(items);
        }

        #endregion List

        #region Delete        

        /// <summary>
        /// Deletes the pre-filing request.
        /// </summary>
        /// <param name="id">The pre-filing request identifier.</param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletePreFilingRequestAsync(int id)
        {
            var request = await _service.GetById(id);
            bool notApproved = request.PreFilingStatusId != 1;

            if (notApproved)
            {
                var entity = await _service.GetById(id);

                await _service.Delete(entity);
            }

            return Ok(notApproved);
        }

        #endregion Delete  
    }
}