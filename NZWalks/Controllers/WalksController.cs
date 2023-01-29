using Microsoft.AspNetCore.Mvc;
using NZWalks.Models.Domain;

namespace NZWalks.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class WalksController : Controller
    {
        [HttpGet]
        public IActionResult GetAllWalk()
        {
            var Walks = new List<Walk>() 
            {
                new Walk
                {
                    Id=Guid.NewGuid(),
                    Name="Sengeti",
                    Length=3,
                    RegionId=Guid.NewGuid(),    
                    WalkDifficultyID=Guid.NewGuid(),    
                },
                 new Walk
                {
                    Id=Guid.NewGuid(),
                    Name="Kaziranga",
                    Length=10,
                    RegionId=Guid.NewGuid(),
                    WalkDifficultyID=Guid.NewGuid(),
                }


            };

            return Ok(Walks);
        }
    }
}
