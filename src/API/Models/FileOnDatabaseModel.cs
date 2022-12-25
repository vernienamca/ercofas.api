using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ERCOFAS.Api.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileOnDatabaseModel : SealingAndAcceptanceTestingModel
    {
        public byte[] Data { get; set; }
    }
}
