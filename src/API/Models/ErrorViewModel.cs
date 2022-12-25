using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ERCOFAS.Api.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    ublic DateTime? CreatedOn { get; set; }
}
}
