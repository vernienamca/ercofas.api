using ERCOFAS.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ERCOFAS.Api.Controllers
{
    /// <summary>
    /// The role controller.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("[controller]")]
    public class RoleController : ControllerBase
    {
        #region Variables

        private readonly IRoleService _service;

        #endregion Variables

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleController"/> class.
        /// <param name="service">The settings service.</param>
        /// </summary>
        public RoleController(IRoleService service)
        {
            _service = service;
        }
    }
}
