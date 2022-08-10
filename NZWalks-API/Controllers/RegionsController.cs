using Microsoft.AspNetCore.Mvc;
using NZWalks_API.Models.Domain;
using NZWalks_API.Repositories;
namespace NZWalks_API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
   public class RegionsController : Controller
    {
      private readonly IRegionRepository regionRepository;

      public RegionsController(IRegionRepository regionRepository)
      {
        this.regionRepository = regionRepository; 
      }

        [HttpGet]
        public IActionResult GetAllRegions()
        {
          var regions = regionRepository.GettAll();
          
            
          
          return Ok(regions);
        }
    }
}