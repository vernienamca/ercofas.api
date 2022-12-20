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
    public class PagesController : ControllerBase
    {
        #region Variables

        private readonly IPageService _pageService;
        private readonly IManageRoleService _manageRoleService;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesController"/> class.
        /// <param name="pageService">The page service.</param>
        /// <param name="manageRolesService">The manage roles service.</param>
        /// </summary>
        public PagesController(IPageService pageService, IManageRoleService manageRoleService)
        {
            _pageService = pageService;
            _manageRoleService = manageRoleService;
        }

        #endregion Constructor

        #region Post

        /// <summary>
        /// Posts the save manage roles.
        /// </summary>
        /// <param name="data">The manage role data object.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">command</exception>
        [HttpPost("save-manage-roles")]
        public async Task<IActionResult> PostSaveManageRolesAsync([FromBody] List<ManageRoleDTO> manageRoles)
        {
            if (manageRoles == null)
                throw new ArgumentNullException(nameof(manageRoles));

            int pageId = manageRoles.FirstOrDefault().PageId;
            int[] manageRoleIds = manageRoles.Select(x => x.Id).ToArray();

            await _manageRoleService.DeleteRange(pageId, manageRoleIds);

            foreach (var item in manageRoles)
            {
                var manageRole = await _manageRoleService.GetById(item.Id, item.PageId, item.RoleId);

                if (manageRole != null)
                    await _manageRoleService.Update(item, manageRole);
                else
                    await _manageRoleService.Add(item);
            }
            
            return Ok();
        }

        #endregion Post

        #region Put

        /// <summary>
        /// Puts the update page.
        /// </summary>
        /// <param name="data">The page data object.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">command</exception>
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutUpdatePageAsync([FromBody] PageDTO data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            var page = await _pageService.Update(data);

            return Ok(page);
        }

        #endregion Put

        #region Get

        /// <summary>
        /// Gets the page by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPageById(int id)
        {
            var entity = await _pageService.GetById(id);

            return Ok(entity);
        }

        #endregion Get

        #region List

        /// <summary>
        /// Gets the list pages.
        /// </summary>
        /// <returns></returns>
        [HttpGet("lists")]
        public async Task<IActionResult> GetListPagesAsync([FromQuery] string searchValue = "", int currentPage = 1, int pageSize = 10)
        {
            IQueryable<Page> result = _pageService.Get();

            if (!string.IsNullOrEmpty(searchValue))
                result = result.Where(x => x.PageName.ToLower().Contains(searchValue.ToLower()) || x.Description.ToLower().Contains(searchValue.ToLower()));

            var paginatedList = await PaginatedList<Page>.CreateAsync(result.OrderByDescending(x => x.Id), currentPage, pageSize);

            List<object> items = new List<object>();
            foreach (var item in paginatedList)
            {
                items.Add(new
                {
                   id = item.Id,
                   pageName = item.PageName,
                   description = item.Description,
                   urlPath = item.UrlPath,
                   parentMenu = item.ParentMenu,
                   icon = item.Icon,
                   createdBy = item.Order,
                   isParent = item.IsParent,
                   isVisible = item.IsVisible,
                   accessibleByAll = item.AccessibleByAll,
                   status = item.IsActive,
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

        /// <summary>
        /// Gets the list of manage roles.
        /// </summary>
        /// <returns></returns>
        [HttpGet("manage-roles")]
        public IActionResult GetListManageRoles([FromQuery] int pageId, string searchValue = "")
        {
            var manageRoles = _manageRoleService.Get(pageId);

            if (!string.IsNullOrEmpty(searchValue))
                manageRoles = manageRoles.Where(x => x.RoleName.ToLower().Contains(searchValue.ToLower())).ToList();

            return Ok(manageRoles);
        }

        #endregion List
    }
}
