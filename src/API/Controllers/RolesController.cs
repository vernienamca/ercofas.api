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
    /// The role controller.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        #region Variables

        private readonly IRoleService _service;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RolesController"/> class.
        /// <param name="service">The role service.</param>
        /// </summary>
        public RolesController(IRoleService service)
        {
            _service = service;
        }
        #endregion Constructor

        #region Post

        /// <summary>
        /// Posts the create role.
        /// </summary>
        /// <param name="data">The role data object.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">command</exception>
        [HttpPost]
        public async Task<IActionResult> PostCreateRoleAsync([FromBody] RoleDTO data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            var role = await _service.Add(data);

            return Ok(role);
        }

        #endregion Post

        #region Put

        /// <summary>
        /// Puts the update role.
        /// </summary>
        /// <param name="data">The role data object.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">command</exception>
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutUpdateRoleAsync([FromBody] RoleDTO data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            var role = await _service.Update(data);

            return Ok(role);
        }

        #endregion Put

        #region List

        /// <summary>
        /// Gets the list roles.
        /// </summary>
        /// <returns></returns>
        [HttpGet("lists")]
        public async Task<IActionResult> GetListRolesAsync([FromQuery] string searchValue = "", int currentPage = 1, int pageSize = 10)
        {
            IQueryable<Role> result = _service.Get();

            if (!string.IsNullOrEmpty(searchValue))
                result = result.Where(x => x.RoleName.ToLower().Contains(searchValue.ToLower()) || x.Description.ToLower().Contains(searchValue.ToLower()));

            var paginatedList = await PaginatedList<Role>.CreateAsync(result.OrderByDescending(x => x.Id), currentPage, pageSize);

            List<object> items = new List<object>();
            foreach (var item in paginatedList)
            {
                items.Add(new
                {
                   id = item.Id,
                   roleName = item.RoleName,
                   description = item.Description,
                   createdBy = item.CreatedBy,
                   dateCreated = item.DateCreated
                });
            }

            var pagination = new
            {
                totalItems = result.Count(),
                paginatedList.PageCount,
                paginatedList.PageSize
            };

            return Ok(new { items, pagination });
        }

        #endregion List
    }
}
