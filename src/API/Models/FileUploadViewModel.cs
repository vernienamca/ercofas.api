using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ERCOFAS.Api.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadViewModel : ControllerBase
    {
        public List<FileOnDatabaseModel> FilesOnDatabase { get; set; }
    }
}
