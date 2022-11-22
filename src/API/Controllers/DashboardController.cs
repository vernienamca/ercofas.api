using Microsoft.AspNetCore.Mvc;

namespace ERCOFAS.Api.Controllers
{
    /// <summary>
    /// The dasboard controller.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardController"/> class.
        /// </summary>
        public DashboardController()
        {
        }

        [HttpGet("[action]")]
        public string Test()
        {
            return "This is for testing purposes.";
        }
    }
}
