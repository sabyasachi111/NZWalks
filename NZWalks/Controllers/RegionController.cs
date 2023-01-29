using Microsoft.AspNetCore.Mvc;
using NZWalks.Data;
using NZWalks.Models.Domain;
using NZWalks.Repository;

namespace NZWalks.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RegionController : Controller
    {
        private readonly IRegionRepository _regionRepository;
        public RegionController(IRegionRepository regionRepository)
        {
            _regionRepository= regionRepository;
        }
        [HttpGet]
        public IActionResult GetAllRegion()
        {
            var Regions = _regionRepository.GetAll();
               
            return Ok(Regions);
        }
    }
}
