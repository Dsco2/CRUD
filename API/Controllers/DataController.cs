using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : Controller
    {
        private readonly IManagementService _managementService;

        public DataController(IManagementService managementService)
        {
            _managementService = managementService;
        }


        [HttpGet("GetData")]
        public IActionResult Get(int idData)
        {
            var temp = _managementService.GetTable(idData);
            return Ok();
        }
    }
}
