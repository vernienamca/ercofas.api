using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ERCOFAS.Api.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileOnFileSystemModel : SealingAndAcceptanceTestingModel
    {
        public string FilePath { get; set; }
    }
}
