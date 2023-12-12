using HyperCompanyCase.Business.Abstract.Service;
using HyperCompanyCase.Core.Utilities.Result;
using Microsoft.AspNetCore.Mvc;

namespace HyperCompanyCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        [Route("car-by-colorId")]
        public async Task<IActionResult> GetCarsByColorIdAsync([FromQuery] int colorId)
        {
            DataResult dataResult = await _carService.GetCarsByColorIdAsync(colorId);
            return dataResult.HttpResponse();
        }

        [HttpGet]
        [Route("all-car")]
        public async Task<IActionResult> GetAllCarAsync()
        {
            DataResult dataResult = await _carService.GetAllCarListAsync();
            return dataResult.HttpResponse();
        }

        [HttpPut]
        [Route("toggle-headligths")]
        public async Task<IActionResult> ToggleHeadlightsAsync([FromQuery] int carId,bool headLigth)
        {
            DataResult dataResult = await _carService.ToggleHeadlightsAsync(carId,headLigth);
            return dataResult.HttpResponse();
        }

        [HttpDelete]
        [Route("delete-car-by-id")]
        public async Task<IActionResult> DeleteCarByIdAsync([FromQuery] int carId)
        {
            DataResult dataResult = await _carService.DeleteCarByIdAsync(carId);
            return dataResult.HttpResponse();
        }
    }
}
