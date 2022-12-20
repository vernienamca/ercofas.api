using ERCOFAS.Api.Models;
using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Security;
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
    /// The registration controller.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class RegistrationsController : ControllerBase
    {
        #region Variables

        private readonly IRERClassificationService _service;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationController"/> class.
        /// <param name="service">The RER classification service.</param>
        /// </summary>
        public RegistrationsController(IRERClassificationService service)
        {
            _service = service;
        }

        #endregion Constructor

        #region List

        /// <summary>
        /// Gets the list RER classifications by user type.
        /// </summary>
        /// <param name="userTypeId">The user type identifier.</param>
        /// <returns></returns>
        [HttpGet("lists")]
        public IActionResult GetListRERClassifications([FromQuery] byte? userTypeId = null)
        {
            IQueryable<RERClassification> items = _service.GetRERClassifications(userTypeId);

            return Ok(items);
        }

        #endregion List

    }
}