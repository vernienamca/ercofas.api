using Microsoft.AspNetCore.Mvc;

namespace ERCOFAS.Api.Controllers
{
    /// <summary>
    /// The authentication controller.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("[controller]")] 
    public class AuthController : ControllerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthController"/> class.
        /// </summary>
        public AuthController()
        {
        }
    }
}