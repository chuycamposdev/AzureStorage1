using AzureBlobStorage.AzureStorage;
using AzureBlobStorage.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureStorage1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AzureBlobController : ControllerBase
    {
        public AzureBlobController(AzureBlobOptions azureBlobService)
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
