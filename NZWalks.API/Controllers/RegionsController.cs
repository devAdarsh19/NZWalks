using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    // GET:https://localhost:1234/api/Regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.squarespace-cdn.com/content/v1/59fea826fe54eff6e1e8ceb5/1558647678972-Q05SNU5ACBNN6LEVF4MP/Auckland+CBD+skytower.jpg"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Wellington",
                    Code = "WLG",
                    RegionImageUrl = "https://wellingtonnz.bynder.com/transform/f2224523-265d-4578-a72a-b9b068d987ce/Mount-Victoria-Lookout"
                }
            };
            return Ok(regions);
        }
    }
}
