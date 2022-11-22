using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ERCOFAS.ApplicationCore.DTOs;
using ERCOFAS.ApplicationCore.Entities.Structure;
using ERCOFAS.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERCOFAS.Api.Controllers
{
    /// <summary>
    /// The settings controller.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("[controller]")]
    public class SettingsController : ControllerBase
    {
        #region Variables

        private readonly ISettingsService _service;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsController"/> class.
        /// <param name="service">The settings service.</param>
        /// </summary>
        public SettingsController(ISettingsService service)
        {
            _service = service;
        }

        #endregion Constructor

        #region List

        /// <summary>
        /// Gets the list settings.
        /// </summary>
        /// <returns></returns>
        [HttpGet("settings")]
        public IEnumerable<Settings> GetListSettings()
        {
            return _service.Get();
        }

        #endregion List

        #region Get

        /// <summary>
        /// Gets the settings by identifier.
        /// </summary>
        /// <param name="id">The settings identifier.</param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            return Ok(await _service.GetById(id));
        }

        #endregion Get

        #region Put

        /// <summary>
        /// Puts the update settings.
        /// </summary>
        /// <param name="settings">The settings data object.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">command</exception>
        [ProducesResponseType(typeof(SettingsDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> PutUpdateSettings([FromBody] SettingsDTO settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            await _service.Update(settings);

            return Ok(settings.OutSettings);
        }

        #endregion Put
    }
}