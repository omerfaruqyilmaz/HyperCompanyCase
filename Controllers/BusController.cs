using HyperCompanyCase.Business.Abstract.Service;
using HyperCompanyCase.Core.Utilities.Result;
using Microsoft.AspNetCore.Mvc;

namespace HyperCompanyCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusService _busService;
        public BusController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet]
        [Route("bus-by-colorId")]
        public async Task<IActionResult> GetBusesByColorIdAsync([FromQuery] int colorId)
        {
            DataResult dataResult = await _busService.GetBusesByColorIdAsync(colorId);
            return dataResult.HttpResponse();
        }
    }
}
