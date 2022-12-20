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
    public class DocumentsController : ControllerBase
    {
        #region Variables

        private readonly IDocumentsNeededService _service;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsController"/> class.
        /// <param name="service">The RER classification service.</param>
        /// </summary>
        public DocumentsController(IDocumentsNeededService service)
        {
            _service = service;
        }

        #endregion Constructor

        #region List

        /// <summary>
        /// Gets the list documents needed by purpose.
        /// </summary>
        /// <param name="purpose">The purpose.</param>
        /// <returns></returns>
        [HttpGet("lists")]
        public IActionResult GetListDocumentsNeeded([FromQuery] string purpose)
        {
            IQueryable<dynamic> items = _service.Get(purpose);

            return Ok(items);
        }

        #endregion List

    }
}