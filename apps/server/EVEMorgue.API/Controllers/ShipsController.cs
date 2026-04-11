using EVEMorgue.Core.ServicesContracts;
using Microsoft.AspNetCore.Mvc;

namespace EVEMorgue.API.Controllers
{
    [Route("api/[controller]")]
    public class ShipsController(IShipService shipService) : Controller
    {

        [HttpGet]
        [Route("search")]
        public IActionResult Search(string searchTerm)
        {
            var results = shipService.Search(searchTerm);
            return Ok(results);
        }

        [HttpGet]
        [Route("details/{shipId:int}")]
        public IActionResult GetDetails(int shipId)
        {
            var details = shipService.GetDetails(shipId);
            return details is null ? NotFound() : Ok(details);
        }
    }
}
