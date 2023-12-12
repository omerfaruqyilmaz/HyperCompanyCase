using HyperCompanyCase.Business.Abstract.Service;
using HyperCompanyCase.Core.Utilities.Result;
using Microsoft.AspNetCore.Mvc;

namespace HyperCompanyCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {

        private readonly IBoatService _boatService;
        public BoatController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [HttpGet]
        [Route("boats-by-colorId")]
        public async Task<IActionResult> GetBoatsByColorIdAsync([FromQuery] int colorId)
        {
            DataResult dataResult = await _boatService.GetBoatsByColorIdAsync(colorId);
            return dataResult.HttpResponse();
        }
    }
}
